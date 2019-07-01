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
        Bon bon = new Bon();
        Inlog werknemer = new Inlog();
        int tafel_ID;
        decimal amount;
        decimal btw;

        public PaymentActionForm(Inlog werknemer, int tafel_ID, decimal amount, decimal btw, Bon bon)
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.bon = bon;
            this.werknemer = werknemer;
            this.tafel_ID = tafel_ID;
            this.amount = amount;
            this.btw = btw;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            FillLabels();
        }

        private void btnBetaald_Click(object sender, EventArgs e)
        {
            TableForm form = new TableForm(werknemer);
            string paymenttype;
            string comment = txtboxOpmerking.Text;
            string amountWithBtwS = bon.totaalprijs.ToString().Replace(',', '.');
            string tipS = bon.fooi.ToString().Replace(',', '.');

            //bon.bestelling_ID

            paymenttype = PaymentType();

            if(paymenttype != "")
            {
                bonService.Paid(tafel_ID, amountWithBtwS, tipS, comment, bon.bestelling_ID, paymenttype);

                this.Close();
                form.ShowDialog();
            }
        }
        
        private string PaymentType()
        {
            string paymenttype = "";

            if (radioBtnCreditcard.Checked)
            {
                paymenttype = "Creditcard";
            }
            if (radioBtnContant.Checked)
            {
                paymenttype = "Contant";
            }
            if (radioBtnPinpas.Checked)
            {
                paymenttype = "Pinpas";
            }

            return paymenttype;
        }

        private void FillLabels()
        {
            decimal totalPayment = bon.totaalprijs + bon.fooi;

            lblName.Text = werknemer.naam;
            lblTafelNr.Text = tafel_ID.ToString();
            lblAmount.Text = "€ " + amount.ToString("0.##");
            lblBtw.Text = "€ " + btw.ToString("0.##");
            lblBtwAmount.Text = "€ " + bon.totaalprijs.ToString("0.##");
            lblTip.Text = "€ " + bon.fooi.ToString("0.##");
            lblTotalAmount.Text = "€ " + totalPayment.ToString("0.##");
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
