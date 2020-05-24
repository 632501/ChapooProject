using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooModel;
using ChapooLogica;
using ChapooModel.Models;

namespace ChapooUI
{
    public partial class KitchenActionForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        // Order service object
        private readonly Order_Service order_Service = new Order_Service();

        // Inlog object
        private Inlog inlog;

        //Properties
        private bool isBar;
        private bool statusFilter = true;

        public KitchenActionForm(Inlog inlog)
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            // We assign the inlog object we get to our own inlog property
            this.inlog = inlog;
        }

        private void KitchenActionForm_Load(object sender, EventArgs e)
        {
            // Call the method that will load the data.
            UpdateData();

            // Change visual to bar or kitchen based on users work position.
            loginLabel.Text = inlog.naam;
            if(inlog.functie == "barman")
            {
                this.Text = "Bar Overzicht";
                isBar = true;
            }
            else
            {
                this.Text = "Keuken Overzicht";
                isBar = false;
            }
        }

        private void ordersListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            // Don't allow column width changing by user
            e.NewWidth = this.ordersListView.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
        public void UpdateData()
        {
            // If our getOrdersWorker is not busy with a task order him to start one.
            if (!getOrdersWorker.IsBusy)
            {
                getOrdersWorker.RunWorkerAsync();
            }
        }
        private void getOrdersWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<BestellingOrderItem> todaysOrdersList = new List<BestellingOrderItem>();

            // Continue only if our ordersListView is not currently being used by something else.
            if (ordersListView.InvokeRequired)
            {
                // Tell the rest that you are busy with ordersListView
                ordersListView.Invoke((MethodInvoker)delegate ()
                {
                    // If the users work position is bar call GetAllBarOrders else call GetAllKitchenOrders
                    if (isBar == true)
                    {
                        // Fill our list with GetAllBarOrders method, statusFilter says if we want the data with finished orders.   
                        todaysOrdersList = order_Service.GetAllBarOrders(statusFilter);
                    }
                    else
                    {
                        // Fill our list with GetAllKitchenOrders method, statusFilter says if we want the data with finished orders.   
                        todaysOrdersList = order_Service.GetAllKitchenOrders(statusFilter);

                    }
                });
            }
            e.Result = todaysOrdersList;
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            // Update our data every 30 seconds for new orders.
            UpdateData();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            // Log the user out by closing this form and opening LoginForm.
            this.Close();
            LoginForm form = new LoginForm();
            form.ShowDialog();
        }

        private void ordersListView_Click(object sender, EventArgs e)
        {
            // When a list item is selected check if nothing went wrong and we have the item information
            if (ordersListView.SelectedItems.Count < 1) return;
           
            ListViewItem selectedItem = ordersListView.SelectedItems[0];
            bool isDone = true;

            BestellingOrderItem item = (BestellingOrderItem)selectedItem.Tag;

            if (selectedItem.ForeColor == Color.LightCoral)
                isDone = false;
                
            // Send the selected item as BestellingOrderItem object to our OrderDoActionForm.    
            OrderDoActionForm ordersOverviewForm = new OrderDoActionForm(item, this, isDone);
            ordersOverviewForm.ShowDialog();
            
        }


        private void filterButton_Click(object sender, EventArgs e)
        {
            // When statusFilter button is clicked the pictures will change
            if (statusFilter)
            {
                checkPicture.Visible = true;
            }
            else
            {
                checkPicture.Visible = false;

            }
            // Update our data again with the preferred statusFilter.
            statusFilter = !statusFilter;
            UpdateData();
        }

        private void getOrdersWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // When the worker completes get the list from the worker and send it to our fillListView method.
            // CreateColumns of the list.
            List<BestellingOrderItem> bestellingOrderItems = (List<BestellingOrderItem>)e.Result;
            if (bestellingOrderItems.Count > 0)
            {
                fillListView(bestellingOrderItems);
                createColumns();
            }
        }
        private void fillListView(List<BestellingOrderItem> bestellingOrderItems)
        {
            // Fills the ordersListView with the incoming list.
            ordersListView.Clear();
            foreach (BestellingOrderItem  orderItem in bestellingOrderItems)
            {
                var item = new ListViewItem(new[] {
                            orderItem.TafelNummer.ToString(),
                            orderItem.Aantal.ToString(),
                            orderItem.MenuItemNaam.ToString(),
                            orderItem.OrderCommentaar.ToString(),
                            orderItem.WerknemerNaam.ToString(),
                            orderItem.Datum.Value.ToString("hh:mm")
                            });
                item.Tag = orderItem;
                if (orderItem.Status == "Gereed")
                {
                    item.ForeColor = Color.LightCoral;
                }
                ordersListView.Items.Add(item);
            }

        }
        private void createColumns()
        {
            // Creates columns for the listview.
            ordersListView.View = View.Details;
            ordersListView.Columns.Add("Tafel");
            ordersListView.Columns.Add("#");
            ordersListView.Columns.Add("Bestelling");
            ordersListView.Columns.Add("Commentaar");
            ordersListView.Columns.Add("Werknemer");
            ordersListView.Columns.Add("Tijd");

            ordersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ordersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            ordersListView.Columns[1].Width = 55;
            ordersListView.Columns[2].Width = 320;
            ordersListView.Columns[3].Width = 200;
            ordersListView.Columns[4].Width = 235;

        }
        private void stockButton_Click(object sender, EventArgs e)
        {
            // Opens stock form window.
            ManagementSupplyForm supplyForm = new ManagementSupplyForm(inlog);
            supplyForm.ShowDialog();
        }

        private void ordersListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
