using ChapooModel;
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
using ChapooLogica;
using ChapooModel.Models;
using MenuItem = ChapooModel.MenuItem;
using ChapooUI.Service;

namespace ChapooUI
{
    public partial class OrderMenusForm2 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        int tafelNummer { get; set; }
        public Bestelling bestelling = new Bestelling();
        Inlog werknemer { get; set; }
        Bestelling_Service bestellingService = new Bestelling_Service();
        Menu_Service menuService = new Menu_Service();
        

        public OrderMenusForm2(Inlog werknemer, int tafelNummer)
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            bestelling.orderItems = new List<OrderItem>();
            
            this.tafelNummer = tafelNummer;
            this.werknemer = werknemer;
        }

        //Laden van toegevoegde orders, leeg als er nog niks is toegevoegd
        public void LoadOrder()
        {
            listviewOrderMenus.Clear();
            string comment = "";
            if (bestelling.orderItems.Count < 1)
            {
                return;
            }
            else
            {
                foreach (OrderItem o in bestelling.orderItems)
                {
                    ListViewItem li = new ListViewItem(o.menuItem.naam);
                    li.SubItems.Add(o.Aantal.ToString());
                    li.SubItems.Add(o.Comment);
                    li.Tag = o;

                    listviewOrderMenus.Items.Add(li);
                    if (o.Comment != "")
                    {
                        comment += o.menuItem.naam + ": " + o.Comment + ", \r\n";
                    }
                }
                listviewOrderMenus.View = View.Details;
                listviewOrderMenus.Columns.Add("Naam");
                listviewOrderMenus.Columns.Add("Aantal");
                listviewOrderMenus.Columns.Add("Commentaar");
            }
            rtxtCommentaar.Text = comment;
        }

        //Button events

        //private void btnIncrease_Click(object sender, EventArgs e)
        //{
        //    if (mlistviewOrderMenus.SelectedItems.Count > 0)
        //    {
        //        //foreach (OrderItem item in bestelling.orderItems)
        //        //{
        //            OrderItem item = (OrderItem)mlistviewOrderMenus.SelectedItems[0].Tag;
        //            item.Aantal += 1;
        //            mlistviewOrderMenus.Clear();
        //            LoadOrder();
        //        //}
        //    }
        //}

        //private void btnDecrease_Click(object sender, EventArgs e)
        //{
        //    if (mlistviewOrderMenus.SelectedItems.Count > 0)
        //    {
        //        OrderItem o = (OrderItem)listviewTakenOrder.SelectedItems[0].Tag;
        //        o.Aantal -= 1;

        //        listviewTakenOrder.Clear();
        //        if (o.Aantal == 0)
        //        {
        //            bestelling.orderItems.Remove(o);
        //        }
        //        LoadOrder();
        //    }
        //}

        private void OrderMenusForm_Load_1(object sender, EventArgs e)
        {
            mlblTafel.Text = "Tafel: " + tafelNummer;
            mlblNaam.Text = werknemer.naam;
            LoadOrder();
        }

        private void MbtnDrinken_Click(object sender, EventArgs e)
        {
            //listviewOrderMenus.Clear();
            this.Hide();
            OrderForm2 drinksForm = new OrderForm2("Drinks", tafelNummer, bestelling, werknemer, this);
            drinksForm.Show();
        }

        private void MbtnLunch_Click(object sender, EventArgs e)
        {
            //listviewOrderMenus.Clear();
            this.Hide();
            OrderForm2 lunchForm = new OrderForm2("Lunch", tafelNummer, bestelling, werknemer, this);
            lunchForm.Show();
        }

        private void MbtnDiner_Click(object sender, EventArgs e)
        {
            //listviewOrderMenus.Clear();
            this.Hide();
            OrderForm2 dinerForm = new OrderForm2("Diner", tafelNummer, bestelling, werknemer, this);
            dinerForm.Show();
        }

        private void MbtnToevoegen_Click(object sender, EventArgs e)
        {
            List<OrderItem> orders = bestelling.orderItems;
            bestelling.tafel_id = tafelNummer;
            bestelling.datum = DateTime.Now;
            bestelling.werknemer = werknemer;
            bestelling.commentaar = rtxtCommentaar.Text;

            //Bestelling toevoegen aan db
            bestellingService.AddOrder(bestelling);

            //krijg het ID van toegevoegde bestelling voor orderitems.
            bestelling = bestellingService.GetLatestOrder();

            foreach (OrderItem o in orders)
            {
                //voorraad aanpassen in db
                int voorraad = o.menuItem.voorraad;
                voorraad = voorraad - o.Aantal;
                menuService.ChangeSupply(o.menuItem.naam, voorraad);

                //Orderitem toevoegen aan db
                o.bestelling_id = bestelling.bestelling_id;
                o.Werknemer = werknemer;
                o.tafel_id = tafelNummer;
                bestellingService.AddOrderItem(o);
            }

            MessageBox.Show("Bestelling is doorgevoerd met id: " + bestelling.bestelling_id);

            this.Close();
            OrderOverviewForm2 overviewForm = new OrderOverviewForm2(werknemer, tafelNummer);
            overviewForm.Show();
        }

        private void MbtnTerug_Click(object sender, EventArgs e)
        {
            OrderActionForm2 form = new OrderActionForm2(werknemer, tafelNummer);
            this.Close();
            form.Show();
        }

        private void MbtnUitloggen_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
