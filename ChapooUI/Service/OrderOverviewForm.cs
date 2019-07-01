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
        Bestelling_Service bestellingService = new Bestelling_Service();
        int tafelNummer { get; set; }
        Inlog werknemer { get; set; }
        List<Bestelling> bestellingen { get; set; }
        List<OrderItem> orderItems { get; set; }

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
            bestellingen = new List<Bestelling>();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            mlblTafel.Text = "Tafel: " + tafelNummer;
            mlblWerknemer.Text = werknemer.naam;
            LoadOrders();
        }

        //Laden van orders in overview
        public void LoadOrders()
        {
            listviewOverview.Clear();
            bestellingen = orderService.GetTablesOrder(tafelNummer);
            foreach (Bestelling bestelling in bestellingen)
            {
                orderItems = orderService.GetTablesOrderItems(tafelNummer, bestelling.bestelling_ID);
                foreach (OrderItem item in orderItems)
                {
                    ListViewItem li = new ListViewItem(bestelling.bestelling_ID.ToString());
                    li.SubItems.Add(item.order_ID.ToString());
                    li.SubItems.Add(item.menuItem.naam);
                    li.SubItems.Add(item.Aantal.ToString());
                    listviewOverview.Items.Add(li);
                }
            }
            

            listviewOverview.View = View.Details;
            listviewOverview.Columns.Add("OrderID");
            listviewOverview.Columns.Add("BestellingID");
            listviewOverview.Columns.Add("Besteld");
            listviewOverview.Columns.Add("Aantal");
          
        }

        //Deleten van een enkele Orderitem
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
                if (listviewOverview.SelectedItems.Count < 1)
                {
                    MessageBox.Show("Selecteer een orderitem");
                    return;
                }
                else
                {
                DialogResult res = MessageBox.Show("Weet je het zeker dat je deze orderitem wilt verwijderen?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    int orderId = int.Parse(listviewOverview.SelectedItems[0].SubItems[1].Text);
                    orderService.DeleteOrder(orderId);

                    LoadOrders();
                } else if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("Verwijderen is gecancelled.");
                }
            }
            

        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            OrderActionForm form = new OrderActionForm(werknemer, tafelNummer);
            this.Close();
            form.Show();
        }

        //Deleten van volledige order uit db
        private void btnDeleteFullOrder_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Weet je het zeker dat je deze bestelling wilt verwijderen?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                int bestellingnr = int.Parse(txtGetOrderNr.Text);
                orderService.DeleteOrderItemsByID(bestellingnr);
                bestellingService.DeleteOrders(bestellingnr);
                LoadOrders();
            }
            if (res == DialogResult.Cancel)
            {
                MessageBox.Show("Verwijderen is gecancelled.");
            }
            
        }
    }
}
