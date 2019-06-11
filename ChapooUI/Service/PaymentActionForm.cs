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

        int amount;
        int tip;
        int btw;
        Inlog werknemer = new Inlog();
        int tafel_ID;

        public PaymentActionForm(Inlog werknemer, int tafel_ID)
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.amount = amount;
            this.tip = tip;
            this.btw = btw;
            this.tafel_ID = tafel_ID;
            this.werknemer = werknemer;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            Bestelling order = new Bestelling();
            order = bonService.Orders(tafel_ID); 
            
            int btwAmount = amount + btw;
            int totalamount = btwAmount + tip;

            int bedrag = 6;

            lblAmount.Text = "10";
            lblBtw.Text = "0,60";
            lblBtwAmount.Text = "10,60";
            lblTip.Text = "2";
            lblTotalAmount.Text = "12,60";

            //lblAmount.Text = bedrag.ToString();
            //lblBtw.Text = btw.ToString();
           // lblBtwAmount.Text = btwAmount.ToString();
           // lblTip.Text = tip.ToString();
           // lblTotalAmount.Text = totalamount.ToString();

            lblName.Text = werknemer.naam;
            lblTafelNr.Text = tafel_ID.ToString();
        }

        private void btnBetaald_Click(object sender, EventArgs e)
        {
            string paymenttype;
            string comment = txtboxOpmerking.Text;
            int tip = int.Parse(lblTip.Text);
            TableForm form = new TableForm(werknemer);

            if (radioBtnCreditcard.Checked && !radioBtnContant.Checked && !radioBtnPinpas.Checked)
            {
                //paymenttype = "Creditcard";
                //bonService.Paid(tafel_ID, tip, paymenttype, comment);

                this.Close();
                form.ShowDialog();
            }
            if (radioBtnContant.Checked && !radioBtnCreditcard.Checked && !radioBtnPinpas.Checked)
            {
               // paymenttype = "Contant";
               //bonService.Paid(tafel_ID, tip, paymenttype, comment);

                this.Close();
                form.ShowDialog();
            }
            if (radioBtnPinpas.Checked && !radioBtnContant.Checked && !radioBtnCreditcard.Checked)
            {
               // paymenttype = "Pinpas";
              //  bonService.Paid(tafel_ID, tip, paymenttype, comment);

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
