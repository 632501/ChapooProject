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
        private readonly Order_Service order_Service = new Order_Service();
        private Inlog inlog;
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
            this.inlog = inlog;
        }

        private void KitchenActionForm_Load(object sender, EventArgs e)
        {
            UpdateData();
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
            e.NewWidth = this.ordersListView.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
        public void UpdateData()
        {
            if (!getOrdersWorker.IsBusy)
            {
                getOrdersWorker.RunWorkerAsync();
            }
        }
        private void getOrdersWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<BestellingOrderItem> todaysOrdersList = new List<BestellingOrderItem>();

            if (ordersListView.InvokeRequired)
            {
                ordersListView.Invoke((MethodInvoker)delegate ()
                {
                    if (isBar == true)
                    {
                            todaysOrdersList = order_Service.GetAllBarOrders(statusFilter);
                    }
                    else
                    {
                        todaysOrdersList = order_Service.GetAllKitchenOrders(statusFilter);

                    }
                });
            }
            e.Result = todaysOrdersList;
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm form = new LoginForm();
            form.ShowDialog();
        }

        private void ordersListView_Click(object sender, EventArgs e)
        {
            if (ordersListView.SelectedItems.Count < 1) return;

            ListViewItem selectedItem = ordersListView.SelectedItems[0];
            bool isDone = true;

            BestellingOrderItem item = (BestellingOrderItem)selectedItem.Tag;

            if (selectedItem.ForeColor == Color.LightCoral)
                isDone = false;
      
                OrderDoActionForm ordersOverviewForm = new OrderDoActionForm(item, this, isDone);
                ordersOverviewForm.ShowDialog();
            
        }


        private void filterButton_Click(object sender, EventArgs e)
        {
            if (statusFilter)
            {
                checkPicture.Visible = true;
            }
            else
            {
                checkPicture.Visible = false;

            }
            UpdateData();
            statusFilter = !statusFilter;
        }

        private void getOrdersWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<BestellingOrderItem> bestellingOrderItems = (List<BestellingOrderItem>)e.Result;
            if (bestellingOrderItems.Count > 0)
            {
                fillListView(bestellingOrderItems);
                createColumns();
            }
        }
        private void fillListView(List<BestellingOrderItem> bestellingOrderItems)
        {
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
            ManagementSupplyForm supplyForm = new ManagementSupplyForm(inlog);
            supplyForm.ShowDialog();
        }

        private void ordersListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
