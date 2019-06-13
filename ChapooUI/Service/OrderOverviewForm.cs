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
using ChapooModel.Models;
using ChapooLogica;

namespace ChapooUI
{
    public partial class OrderOverviewForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        Order_Service orderService = new Order_Service();
        int tafelNummer { get; set; }
        Inlog werknemer { get; set; }

        public OrderOverviewForm(Inlog inlog, int tafelNummer)
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            werknemer = inlog;
            this.tafelNummer = tafelNummer;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        public void LoadOrders()
        {
            listviewOverview.Clear();
            List<Bestelling> bestellingen = orderService.GetTablesOrder(tafelNummer);
            foreach (Bestelling bestelling in bestellingen)
            {
                List<OrderItem> orderItems = orderService.GetTablesOrderItems(tafelNummer, bestelling.bestelling_ID);
                foreach (OrderItem item in orderItems)
                {
                    ListViewItem li = new ListViewItem(item.order_ID.ToString());
                    li.SubItems.Add(item.menuItem.naam);
                    li.SubItems.Add(item.Aantal.ToString());
                    listviewOverview.Items.Add(li);
                }
            }
            

            listviewOverview.View = View.Details;
            listviewOverview.Columns.Add("BestellingID");
            listviewOverview.Columns.Add("Besteld");
            listviewOverview.Columns.Add("Aantal");
          
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (listviewOverview.SelectedItems.Count < 1)
            {
                MessageBox.Show("Selecteer een orderitem");
                return;
            } else
            {
                int orderId = int.Parse(listviewOverview.SelectedItems[0].Text);
                orderService.DeleteOrder(orderId);

                LoadOrders();
            }
            
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            OrderActionForm form = new OrderActionForm(werknemer, tafelNummer);
            this.Close();
            form.Show();
        }
    }
}
