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

namespace ChapooUI
{
    public partial class OrderMenusForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        int tafelNummer;
        private Bestelling bestelling = new Bestelling();

        public OrderMenusForm(int tafelNummer, Bestelling bestelling)
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.bestelling = bestelling;
            this.tafelNummer = tafelNummer;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            lbl_Table.Text = "Tafel: " + tafelNummer;
        }

        private void listviewMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void OrderMenusForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDiner_Click(object sender, EventArgs e)
        {
            
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {

        }

        public void btnDrinks_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm drinksForm = new OrderForm("Drinks", tafelNummer, bestelling);
            //drinksForm.GetOrder("Drinks");
            drinksForm.Show();
        }

        public void btnLunch_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm lunchForm = new OrderForm("Lunch",tafelNummer, bestelling);
            //lunchForm.GetOrder("Lunch");
            lunchForm.Show();
        }

        public void btnDiner_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm dinerForm = new OrderForm("Diner",tafelNummer, bestelling);
            //dinerForm.GetOrder("Diner");
            dinerForm.Show();
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            Inlog werknemer = new Inlog();
            OrderActionForm form = new OrderActionForm(werknemer, tafelNummer);
            this.Close();
            form.ShowDialog();
        }
    }
}
