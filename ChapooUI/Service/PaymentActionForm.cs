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

        public PaymentActionForm(int amount, int tip, int btw)
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
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            Bestelling order = new Bestelling();
            order = bonService.Orders(4); // tafelnummer nog op een goede manier
            
            
            int btwAmount = amount + btw;
            int totalamount = btwAmount + tip;

            lblAmount.Text = amount.ToString();
            lblBtw.Text = btw.ToString();
            lblBtwAmount.Text = btwAmount.ToString();
            lblTip.Text = tip.ToString();
            lblTotalAmount.Text = totalamount.ToString();
        }

        private void btnBetaald_Click(object sender, EventArgs e)
        {
            string paymenttype;
            string comment = txtboxOpmerking.Text;
            int tip = int.Parse(lblTip.Text);
            int table = 4; // tafelnummer fixen

            if (radioBtnCreditcard.Checked && !radioBtnContant.Checked && !radioBtnPinpas.Checked)
            {
                paymenttype = "Creditcard";
                bonService.Paid(table, tip, paymenttype, comment);
                // doorverwijzen naar tafelform
            }
            if (radioBtnContant.Checked && !radioBtnCreditcard.Checked && !radioBtnPinpas.Checked)
            {
                paymenttype = "Contant";
                bonService.Paid(table, tip, paymenttype, comment);
                // doorverwijzen naar tafelform
            }
            if (radioBtnPinpas.Checked && !radioBtnContant.Checked && !radioBtnCreditcard.Checked)
            {
                paymenttype = "Pinpas";
                bonService.Paid(table, tip, paymenttype, comment);
                // doorverwijzen naar tafelform
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
