﻿using MaterialSkin;
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
using ChapooLogica;
using ChapooModel;
using MenuItem = ChapooModel.MenuItem;
using ChapooModel.Models;

namespace ChapooUI
{
    public partial class OrderForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private string sort;
        private List<MenuItem> menuList;
        Menu_Service menuService = new Menu_Service();
        private int tafelNummer;
        Bestelling bestelling = new Bestelling();
        Inlog werknemer = new Inlog();
        Bestelling_Service bestellingService = new Bestelling_Service();

        public OrderForm(string sort, int tafelNummer, Bestelling bestelling, Inlog werknemer)
        {
            this.sort = sort;
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.bestelling = bestelling;
            this.tafelNummer = tafelNummer;
            this.werknemer = werknemer;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            GetMenus();

            lbl_Table.Text = "Tafel: " + tafelNummer;
        }

        private void listviewMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        public void GetMenus()
        {
            int aantal = 0;
            menuList = new List<MenuItem>();

            listviewMenu.Items.Clear();
            
            if (sort == "Drinks")
            {
                mlblSoortBestelling.Text = "Dranken";
                Menu_Service menuService = new Menu_Service();
                menuList = menuService.GetDrinks();


            } else if (sort == "Lunch")
            {
                mlblSoortBestelling.Text = "Lunch";
                Menu_Service menuService = new Menu_Service();
                menuList = menuService.GetLunch();

            } else if (sort == "Diner")
            {
                mlblSoortBestelling.Text = "Diner";
                Menu_Service menuService = new Menu_Service();
                menuList = menuService.GetDiner();

            }

            foreach (MenuItem m in menuList)
            {
                ListViewItem li = new ListViewItem(m.naam);
                li.SubItems.Add(aantal.ToString());
                li.Tag = m;
                listviewMenu.Items.Add(li);

            }
            listviewMenu.View = View.Details;
            listviewMenu.Columns.Add("Naam");
            listviewMenu.Columns.Add("Aantal");
        }

        public void GetOrder()
        {
            //yikes
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int aantal = int.Parse(listviewMenu.SelectedItems[0].SubItems[1].Text);
            aantal++;
            listviewMenu.SelectedItems[0].SubItems[1].Text = aantal.ToString();

        }
        

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            int aantal = int.Parse(listviewMenu.SelectedItems[0].SubItems[1].Text);
            if (aantal == 0)
            {
                return;
            } else
            {
                aantal--;
            }
            listviewMenu.SelectedItems[0].SubItems[1].Text = aantal.ToString();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            bestelling.werknemer = werknemer;
            bestelling.tafel_ID = tafelNummer;
            bestelling.datum = DateTime.Today;
            bestelling.betaald = false;
            bestelling.orderItems = new List<OrderItem>();
            OrderItem o;
            MenuItem m = new MenuItem();
            int i = 0;
            foreach (ListViewItem li in listviewMenu.Items)
            {
                m.naam = li.SubItems[0].Text;
                string a = "";
                a = li.SubItems[1].Text;
                i = int.Parse(a);
                if (i != 0)
                {
                    m = menuService.GetItem(m.naam);
                    o = new OrderItem();
                    o.menuItem = m;
                    o.Aantal = i;
                    o.Status = "bezig";
                    o.TafelNummer = tafelNummer;
                    o.order_ID = o.order_ID;
                    o.bestelling_ID = bestelling.bestelling_ID;

                    //bestellingService.AddOrderItem(o);
                    bestelling.orderItems.Add(o);
                }
                
            }
            MessageBox.Show("Er is een nieuwe order gemaakt");
            this.Close();
            OrderMenusForm orderForm = new OrderMenusForm(werknemer, tafelNummer, bestelling);
            orderForm.Show();
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            OrderMenusForm form = new OrderMenusForm(werknemer, tafelNummer, bestelling);
            this.Close();
            form.Show();
        }
    }
}
