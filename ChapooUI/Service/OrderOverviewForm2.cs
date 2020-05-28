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
using ChapooUI.Service;

namespace ChapooUI
{
    public partial class OrderOverviewForm2 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        Order_Service orderService = new Order_Service();
        Bestelling_Service bestellingService = new Bestelling_Service();
        int tafelNummer { get; set; }
        Inlog werknemer { get; set; }
        List<Bestelling> bestellingen { get; set; }
        List<OrderItem> orderItems { get; set; }

        public OrderOverviewForm2(Inlog inlog, int tafelNummer)
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
            mlblNaam.Text = werknemer.naam;
            LoadOrders();
        }

        //Laden van orders in overview
        public void LoadOrders()
        {
            listviewOverview.Clear();
            bestellingen = orderService.GetTablesOrder(tafelNummer);
            foreach (Bestelling bestelling in bestellingen)
            {
                orderItems = orderService.GetTablesOrderItems(tafelNummer, bestelling.bestelling_id);
                foreach (OrderItem item in orderItems)
                {
                    ListViewItem li = new ListViewItem(bestelling.bestelling_id.ToString());
                    li.SubItems.Add(item.menuItem.naam);
                    li.SubItems.Add(item.Aantal.ToString());
                    li.SubItems.Add(item.Comment);
                    li.Tag = item;
                    listviewOverview.Items.Add(li);
                }
            }


            listviewOverview.View = View.Details;
            listviewOverview.Columns.Add("ID");
            listviewOverview.Columns.Add("Besteld");
            listviewOverview.Columns.Add("#");
            listviewOverview.Columns.Add("Commentaar");
          
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
                    OrderItem o = (OrderItem)listviewOverview.SelectedItems[0].Tag;
                    orderService.DeleteOrder(o.order_id);

                    LoadOrders();
                } else if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("Verwijderen is gecancelled.");
                }
            }
            

        }

        private void MbtnUitloggen_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void MbtnTerug_Click(object sender, EventArgs e)
        {
            OrderActionForm2 form = new OrderActionForm2(werknemer, tafelNummer);
            this.Close();
            form.Show();
        }

        private void MbtnBetalen_Click(object sender, EventArgs e)
        {
            PaymentForm pform = new PaymentForm(werknemer, tafelNummer, this);
            
            pform.Show();
            this.Close();
        }

        private void ListviewOverview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listviewOverview.SelectedItems.Count > 0)
            {
                OrderItem item = new OrderItem();
                item = (OrderItem)listviewOverview.SelectedItems[0].Tag;
                //Open edit form die shit edit/verwijderd
                OrderMenuEditForm form = new OrderMenuEditForm(item, this);
                form.Show();
                //OrderMenuAddForm form = new OrderMenuAddForm(item, orderMenusForm, this);
                //form.Show();
            }
        }

        //Deleten van volledige order uit db
        //private void btnDeleteFullOrder_Click(object sender, EventArgs e)
        //{
        //    DialogResult res = MessageBox.Show("Weet je het zeker dat je deze bestelling wilt verwijderen?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //    if (res == DialogResult.OK)
        //    {
        //        int value;
        //        if (int.TryParse(txtGetOrderNr.Text, out value))
        //        {
        //            int bestellingnr = int.Parse(txtGetOrderNr.Text);
        //            orderService.DeleteOrderItemsByID(bestellingnr);
        //            bestellingService.DeleteOrders(bestellingnr);
        //            LoadOrders();
        //        } else
        //        {
        //            MessageBox.Show("OrderNr was incorrect");
        //        }

        //    }
        //    if (res == DialogResult.Cancel)
        //    {
        //        MessageBox.Show("Verwijderen is gecancelled.");
        //    }

        //}
    }
}
