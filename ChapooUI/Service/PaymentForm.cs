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
        Decimal btw;
        Inlog werknemer = new Inlog();
        int tafel_ID = 3;

        public PaymentForm(Inlog werknemer, int tafel_ID )
        {
            InitializeComponent();

            //Initialize MaterialSkinManager;
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.tafel_ID = tafel_ID;
            this.werknemer = werknemer;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            btw = 0;
            Decimal amount = 0;

            Bestelling order = new Bestelling();
            order = bonService.Orders(tafel_ID);

            

            foreach (OrderItem o in order.orderItems)
            {
                btw = btw + (o.Aantal * o.menuItem.prijs * (o.menuItem.btwPercentage / 100 + 1));
            }

            amount = amount + btw;
            string bedrag = "10,60";
            lblTotaalbedrag.Text = "€ " + bedrag;

            //lblTotaalbedrag.Text = "€ " + amount.ToString();

            materialListViewBestelling.Items.Clear();
            materialListViewBestelling.View = View.Details;

            //foreach (OrderItem o in order.orderItems)
            //{
                ListViewItem orderlist = new ListViewItem("5");
                orderlist.SubItems.Add("CocaCola");
                orderlist.SubItems.Add("10");

                materialListViewBestelling.Items.Add(orderlist);
            //}

            lblName.Text = werknemer.naam;
            lblTafelNr.Text = tafel_ID.ToString();
        }

        private void btnBetaald_Click(object sender, EventArgs e)
        {
            //int amount = bonService.TotalAmount(tafel_ID); 
           // int totalPayment = 0;

          //  if (txtboxTotalPayment.Text == "")
           // {
           //     totalPayment = amount + btw;
          //  }
          //  else
          //  {
          //      totalPayment = int.Parse(txtboxTotalPayment.Text);
          //  }

         //   int tip = totalPayment - amount - btw;
            PaymentActionForm pay = new PaymentActionForm(werknemer, tafel_ID);
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
