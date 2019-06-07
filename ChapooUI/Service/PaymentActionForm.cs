using ChapooLogica;
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
    public partial class PaymentActionForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        Bon_Service bonService = new Bon_Service();

        int betaaldbedrag;

        public PaymentActionForm(int betaaldbedrag)
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.betaaldbedrag = betaaldbedrag;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            int totalAmount = bonService.TotalAmount(4); // Tafelnummer nog op een goede manier
            Bestelling bestelling = new Bestelling();

            int amount = bonService.TotalAmount(4);
            int btw = 0;
            int btwAmount = amount + btw;
            int tip = betaaldbedrag - amount;
            int totalamount = btwAmount + tip;

            lblAmount.Text = amount.ToString();
            lblBtw.Text = btw.ToString();
            lblBtwAmount.Text = btwAmount.ToString();
            lblTip.Text = tip.ToString();
            lblTotalAmount.Text = totalamount.ToString();
        }

        private void btnBetaald_Click(object sender, EventArgs e)
        {
            if (radioBtnCreditcard.Checked)
            {

            }


            
            

            // doorverwijzen naar tafelform
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
