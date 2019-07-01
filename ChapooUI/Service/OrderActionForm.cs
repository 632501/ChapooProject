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
    public partial class OrderActionForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        Bestelling_Service bestellingService = new Bestelling_Service();
        Inlog werknemer = new Inlog();
        int tafelNummer { get; set; }

        public OrderActionForm(Inlog werknemer, int tafelNummer)
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.tafelNummer = tafelNummer;
            this.werknemer = werknemer;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            lbl_Name.Text = werknemer.naam;
            lbl_Tafel.Text = "Tafel: "+tafelNummer;
        }

        //Button events
        private void btnActionOpnemen_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderMenusForm form = new OrderMenusForm(werknemer, tafelNummer);
            form.Show();
        }

        private void btnActionBekijken_Click(object sender, EventArgs e)
        {
            PaymentForm form = new PaymentForm(werknemer, tafelNummer);
            form.Show();
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            TableForm form = new TableForm(werknemer);
            this.Close();
            form.Show();
        }

        private void btnBestellingOverview_Click(object sender, EventArgs e)
        {
            OrderOverviewForm form = new OrderOverviewForm(werknemer, tafelNummer);
            this.Close();
            form.Show();
        }

        private void btn_Uitlog_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
