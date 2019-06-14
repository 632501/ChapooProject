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
        Inlog werknemer = new Inlog();
        int tafel_ID;
        decimal amountWithBtw;
        decimal amount;
        decimal btw;

        public PaymentForm(Inlog werknemer, int tafel_ID )
        {
            InitializeComponent();

            //Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.tafel_ID = tafel_ID;
            this.werknemer = werknemer;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            lblName.Text = werknemer.naam;
            lblTafelNr.Text = tafel_ID.ToString();
            amount = 0;
            amountWithBtw = 0;

            Bestelling order = new Bestelling();
            order = bonService.Orders(tafel_ID);
            
            foreach (OrderItem o in order.orderItems)
            {
                decimal btwPercentage = (decimal)o.menuItem.btwPercentage / 100;

                amountWithBtw = amountWithBtw + (o.Aantal * o.menuItem.prijs) * (btwPercentage + 1);
                amount = amount + (o.Aantal * o.menuItem.prijs);
            }

            btw = amountWithBtw - amount;
            
            lblTotaalbedrag.Text = "€ " + amountWithBtw.ToString("0.##");
            
            materialListViewBestelling.Items.Clear();
            materialListViewBestelling.View = View.Details;

            foreach (OrderItem o in order.orderItems)
            {
                ListViewItem orderlist = new ListViewItem(o.Aantal.ToString());
                orderlist.SubItems.Add(o.menuItem.naam);
                orderlist.SubItems.Add(o.menuItem.prijs.ToString());

                materialListViewBestelling.Items.Add(orderlist);
            }
        }

        private void btnBetaald_Click(object sender, EventArgs e)
        {
            decimal totalPayment = 0;
            decimal tip = 0;

            if (txtboxTotalPayment.Text == "")
            {
                totalPayment = amountWithBtw;
            }
            else
            {
                totalPayment = decimal.Parse(txtboxTotalPayment.Text);

                if (totalPayment >= amount)
                {
                    tip = totalPayment - amountWithBtw;
                }
            }

            PaymentActionForm pay = new PaymentActionForm(werknemer, tafel_ID, totalPayment, amountWithBtw, amount, tip);
            pay.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
