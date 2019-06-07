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
    public partial class PaymentForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        Bon_Service bonService = new Bon_Service();

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
            int totalAmount = bonService.TotalAmount(4); // Tafelnummer nog op een goede manier

            Bestelling bestelling = new Bestelling();

            bestelling = bonService.Orders(4); // tafelnummer nog op de goede manier

            materialListViewBestelling.Items.Clear();
            materialListViewBestelling.View = View.Details;


            ListViewItem bestellijst = new ListViewItem("Aantal");
            bestellijst.SubItems.Add("Naam");
            bestellijst.SubItems.Add("Totaalprijs");
        }

        private void btnBetaald_Click(object sender, EventArgs e)
        {
            int betaalbedrag = int.Parse(txtboxTotalPayment.Text);
            PaymentActionForm pay = new PaymentActionForm(betaalbedrag);
            pay.ShowDialog();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
