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

namespace ChapooUI
{
    public partial class OrderMenusForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        int tafelNummer { get; set; }
        public Bestelling bestelling = new Bestelling();
        Inlog werknemer { get; set; }
        Bestelling_Service bestellingService = new Bestelling_Service();
        

        public OrderMenusForm(Inlog werknemer, int tafelNummer)
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

        private void OrderMenusForm_Load(object sender, EventArgs e)
        {
            
            lbl_Table.Text = "Tafel: " + tafelNummer;
            mlblWerknemer.Text = werknemer.naam;
            LoadOrder();
        }

        public void LoadOrder()
        {
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
                    listviewTakenOrder.Items.Add(li);
                }

                listviewTakenOrder.View = View.Details;
                listviewTakenOrder.Columns.Add("Naam");
                listviewTakenOrder.Columns.Add("Aantal");
            }

        }


        public void btnDrinks_Click_1(object sender, EventArgs e)
        {
            listviewTakenOrder.Clear();
            this.Hide();
            OrderForm drinksForm = new OrderForm("Drinks", tafelNummer, bestelling, werknemer, this);
            drinksForm.Show();
        }

        public void btnLunch_Click_1(object sender, EventArgs e)
        {
            listviewTakenOrder.Clear();
            this.Hide();
            OrderForm lunchForm = new OrderForm("Lunch",tafelNummer, bestelling, werknemer, this);
            lunchForm.Show();
        }

        public void btnDiner_Click_1(object sender, EventArgs e)
        {
            listviewTakenOrder.Clear();
            this.Hide();
            OrderForm dinerForm = new OrderForm("Diner",tafelNummer, bestelling, werknemer, this);
            dinerForm.Show();
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            OrderActionForm form = new OrderActionForm(werknemer, tafelNummer);
            this.Close();
            form.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<OrderItem> orders = bestelling.orderItems;
            bestelling.tafel_ID = tafelNummer;
            bestelling.datum = DateTime.Now;
            bestelling.werknemer = werknemer;
            bestellingService.AddOrder(bestelling);
            bestelling = bestellingService.GetLatestOrder();
            
            foreach (OrderItem o in orders)
            {
                o.bestelling_ID = bestelling.bestelling_ID;
                o.Werknemer = werknemer;
                o.TafelNummer = tafelNummer;
                bestellingService.AddOrderItem(o);
            }

            MessageBox.Show("Bestelling is doorgevoerd met id: " + bestelling.bestelling_ID);

            this.Close();
            OrderOverviewForm overviewForm = new OrderOverviewForm(werknemer, tafelNummer);
            overviewForm.Show();

        }
    }
}
