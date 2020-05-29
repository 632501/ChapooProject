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
        Order_Service orderService = new Order_Service();
        Bon bon = new Bon();
        Inlog werknemer = new Inlog();
        Bestelling order = new Bestelling();
        int tafel_ID;
        decimal amount;
        decimal btw;
        OrderOverviewForm2 form2;

        public PaymentForm(Inlog werknemer, int tafel_ID, OrderOverviewForm2 form2)
        {
            InitializeComponent();

            //Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.tafel_ID = tafel_ID;
            this.werknemer = werknemer;
            this.form2 = form2;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            
            order = orderService.Orders(tafel_ID);
            

            Calculation(order);
            ShowList(order);
            FillLabels();
        }

        private void FillLabels()
        {
            lblName.Text = werknemer.naam;
            lblTafelNr.Text = tafel_ID.ToString();
            lblTotaalbedrag.Text = "€ " + bon.totaalprijs.ToString("0.##");
        }

        private void Calculation(Bestelling order)
        {
            amount = 0;
            decimal amountWithBtw = 0;

            foreach (OrderItem o in order.orderItems)
            {
                decimal btwPercentage = (decimal)o.menuItem.btwPercentage / 100;

                amountWithBtw = amountWithBtw + (o.Aantal * o.menuItem.prijs) * (btwPercentage + 1);
                amount = amount + (o.Aantal * o.menuItem.prijs);
            }

            btw = amountWithBtw - amount;
            bon.totaalprijs = amountWithBtw;
        }

        private void ShowList(Bestelling order)
        {
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
            bon.fooi = 0;

            if (txtboxTotalPayment.Text == "")
            {
                totalPayment = bon.totaalprijs;
            }
            else
            {
                totalPayment = decimal.Parse(txtboxTotalPayment.Text);

                if (totalPayment > bon.totaalprijs)
                {
                    bon.fooi = totalPayment - bon.totaalprijs;
                }
            }

            OrderItem item = order.orderItems.First();
            order.bestelling_id = item.bestelling_id;
            bon.bestelling_ID = order.bestelling_id;

            this.Close();
            PaymentActionForm pay = new PaymentActionForm(werknemer, tafel_ID, amount, btw, bon, form2);
            pay.Show();
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
            form2.Show();
            //error kan niet naar verwijderd object.
        }
    }
}
