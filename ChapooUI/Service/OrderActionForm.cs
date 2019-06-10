﻿using ChapooLogica;
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
        int tafelNummer;

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
            lbl_Tafel.Text = tafelNummer.ToString();
        }

        private void listviewMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnActionOpnemen_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderMenusForm orderMenusForm = new OrderMenusForm(tafelNummer);
            orderMenusForm.Show();
        }

        private void btnActionBekijken_Click(object sender, EventArgs e)
        {
            this.Hide();
            //OrderOverviewForm orderOverviewForm = new OrderOverviewForm();
            //orderOverviewForm.Show();
        }

        private void btn_NewOrder_Click(object sender, EventArgs e)
        {
            Bestelling bestelling = new Bestelling();
            bestelling.werknemer = werknemer;
            bestelling.tafel_ID = tafelNummer;
            bestelling.datum = DateTime.Today;
            bestelling.betaald = false;

            bestellingService.AddOrder(bestelling);
            bestelling = bestellingService.GetLatestOrder();

            MessageBox.Show("Er is een nieuwe bestelling aan gemaakt met ID: " + bestelling.bestelling_ID);
        }
    }
}
