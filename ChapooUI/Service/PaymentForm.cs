using ChapooLogica;
using ChapooModel;
using ChapooModel.Models;
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
    public partial class PaymentForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        Bon_Service bonService = new Bon_Service();
        int btw; 

        public PaymentForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            btw = 0;
            int amount = bonService.TotalAmount(4); // Tafelnummer nog op een goede manier

            Bestelling order = new Bestelling();
            order = bonService.Orders(4); // tafelnummer nog op de goede manier
            
            foreach (OrderItem o in order.orderItems)
            {
                btw += (o.Aantal * o.menuItem.prijs * (o.menuItem.btwPercentage / 100 + 1));
            }

            amount += btw;
            lblTotaalbedrag.Text = "€ " + amount.ToString();

            materialListViewBestelling.Items.Clear();
            materialListViewBestelling.View = View.Details;

            foreach(Bestelling b in b)
            {

            }

        private void btnBetaald_Click(object sender, EventArgs e)
        {
            int amount = bonService.TotalAmount(4); // Tafelnummer nog op een goede manier 
            int totalPayment = 0;

            if (txtboxTotalPayment.Text == "")
            {
                totalPayment = amount + btw;
            }
            else
            {
                totalPayment = int.Parse(txtboxTotalPayment.Text);
            }

            int tip = totalPayment - amount - btw;
            PaymentActionForm pay = new PaymentActionForm(amount, tip, btw);
            pay.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
