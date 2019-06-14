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
    public partial class PaymentActionForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        Bon_Service bonService = new Bon_Service();
        Inlog werknemer = new Inlog();
        int tafel_ID;
        decimal totalPayment;
        decimal amountWithBtw;
        decimal amount;
        decimal tip;

        public PaymentActionForm(Inlog werknemer, int tafel_ID, decimal totalPayment, decimal amountWithBtw, decimal amount, decimal tip)
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.werknemer = werknemer;
            this.tafel_ID = tafel_ID;
            this.totalPayment = totalPayment;
            this.amountWithBtw = amountWithBtw;
            this.amount = amount;
            this.tip = tip;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            Bestelling order = new Bestelling();
            order = bonService.Orders(tafel_ID);

            decimal btw = amountWithBtw - amount;

            lblName.Text = werknemer.naam;
            lblTafelNr.Text = tafel_ID.ToString();
            lblAmount.Text = "€ " + amount.ToString("0.##");
            lblBtw.Text = "€ " + btw.ToString("0.##");
            lblBtwAmount.Text = "€ " + amountWithBtw.ToString("0.##");
            lblTip.Text = "€ " + tip.ToString("0.##");
            lblTotalAmount.Text = "€ " + totalPayment.ToString("0.##");
        }

        private void btnBetaald_Click(object sender, EventArgs e)
        {
            TableForm form = new TableForm(werknemer);
            string paymenttype;
            string comment = txtboxOpmerking.Text;
            string amountWithBtwS = amountWithBtw.ToString().Replace(',', '.');
            string tipS = tip.ToString().Replace(',', '.');

            if (radioBtnCreditcard.Checked && !radioBtnContant.Checked && !radioBtnPinpas.Checked)
            {
                paymenttype = "Creditcard";
                bonService.Paid(tafel_ID, amountWithBtwS, tipS, comment, paymenttype);

                this.Close();
                form.ShowDialog();
            }
            if (radioBtnContant.Checked && !radioBtnCreditcard.Checked && !radioBtnPinpas.Checked)
            {
                paymenttype = "Contant";
                bonService.Paid(tafel_ID, amountWithBtwS, tipS, comment, paymenttype);

                this.Close();
                form.ShowDialog();
            }
            if (radioBtnPinpas.Checked && !radioBtnContant.Checked && !radioBtnCreditcard.Checked)
            {
                paymenttype = "Pinpas";
                bonService.Paid(tafel_ID, amountWithBtwS, tipS, comment, paymenttype);

                this.Close();
                form.ShowDialog();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void lblTafelNr_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_Naam_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
