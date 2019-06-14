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
        private List<OrderItem> orderItemLists = new List<OrderItem>();
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
                loadingPicture.Visible = true;
                getOrdersWorker.RunWorkerAsync();
            }
        }
        private void getOrdersWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            List<Bestelling> todaysOrdersList = order_Service.GetTodaysOrders();
            if (ordersListView.InvokeRequired)
            {
                ordersListView.Invoke((MethodInvoker)delegate ()
                {
                    ordersListView.Clear();

                    foreach (Bestelling todaysOrder in todaysOrdersList)
                    {
                        List<OrderItem> orderItemList = new List<OrderItem>();

                        if(isBar == true)
                        {
                            if(statusFilter)
                               orderItemList = todaysOrder.orderItems.Where(m => m.menuItem.categorie == "dranken" && m.Status != "Gereed").ToList();
                            else
                               orderItemList = todaysOrder.orderItems.Where(m => m.menuItem.categorie == "dranken").ToList();
                        }
                        else
                        {
                            if (statusFilter)
                                orderItemList = todaysOrder.orderItems.Where(m => m.menuItem.categorie == "diner" &&  m.Status != "Gereed").ToList();
                            else
                                orderItemList = todaysOrder.orderItems.Where(m => m.menuItem.categorie == "diner").ToList();
                        }

                        foreach (var orderItem in orderItemList)
                        {
                            orderItems.Add(orderItem);
                            var item = new ListViewItem(new[] {
                            orderItem.order_ID.ToString(),
                            orderItem.TafelNummer.ToString(),
                            orderItem.Aantal.ToString(),
                            orderItem.menuItem.naam.ToString(),
                            orderItem.Comment.ToString(),
                            orderItem.Werknemer.naam.ToString(),
                            todaysOrder.datum.Value.ToString("hh:mm")
                            });
                            if(orderItem.Status == "Gereed") {
                                item.ForeColor = Color.Red;
                            }
                            ordersListView.Items.Add(item);
                        }
                  
                    }
                    ordersListView.View = View.Details;
                    ordersListView.Columns.Add("Order");
                    ordersListView.Columns.Add("Tafel");
                    ordersListView.Columns.Add("Aantal");
                    ordersListView.Columns.Add("Bestelling");
                    ordersListView.Columns.Add("Commentaar");
                    ordersListView.Columns.Add("Werknemer");
                    ordersListView.Columns.Add("Tijd");

                    ordersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    ordersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    if (!isBar) { 
                    ordersListView.Columns[3].Width = 233;
                    }
                    else
                    {
                        ordersListView.Columns[3].Width = 170;
                    }
                });
            }
            if (loadingPicture.InvokeRequired)
            {
                loadingPicture.Invoke((MethodInvoker)delegate ()
                {
                    loadingPicture.Visible = false;
                });
            }
            e.Result = orderItems;
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
            int selectedItemIndex = int.Parse(selectedItem.Text);
            bool isDone = true;
            var item = orderItemLists.Where(m => m.order_ID == selectedItemIndex).FirstOrDefault();
            if (selectedItem.ForeColor == Color.Red)
                isDone = false;
            if (selectedItemIndex >= 0)
            {
                OrderDoActionForm ordersOverviewForm = new OrderDoActionForm(item, this, isDone);
                ordersOverviewForm.ShowDialog();
            }
        }

        private void currentTime_Tick(object sender, EventArgs e)
        {
            this.timeLabel.Text = DateTime.Now.ToString();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (statusFilter)
            {
                filterButton.Text = "Gereed bestellingen niet zien";
            }
            else
            {
                filterButton.Text = "Gereed bestellingen zien";

            }
            UpdateData();
            statusFilter = !statusFilter;
        }

        private void getOrdersWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<OrderItem> orderList = (List<OrderItem>)e.Result;
            if (orderList != null)
            {
                orderItemLists.Clear();
                foreach (var item in orderList)
                {
                    orderItemLists.Add(item);
                }
            }
        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            ManagementSupplyForm supplyForm = new ManagementSupplyForm(inlog);
            supplyForm.ShowDialog();
        }
    }
}
