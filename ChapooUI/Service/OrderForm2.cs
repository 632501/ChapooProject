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
using ChapooLogica;
using ChapooModel;
using MenuItem = ChapooModel.MenuItem;
using ChapooModel.Models;

namespace ChapooUI.Service
{
    public partial class OrderForm2 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private string sort { get; set; }
        private List<MenuItem> menuList { get; set; }

        private int tafelnummer { get; set; }
        Bestelling order { get; set; }
        Inlog werknemer { get; set; }
        Bestelling_Service bestellingService = new Bestelling_Service();
        Menu_Service menuService = new Menu_Service();
        OrderMenusForm2 orderMenusForm { get; set; }

        public OrderForm2(string sort, int tafelnummer, Bestelling order, Inlog werknemer, OrderMenusForm2 orderMenusForm)
        {
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.sort = sort;
            this.order = order;
            this.tafelnummer = tafelnummer;
            this.werknemer = werknemer;
            this.orderMenusForm = orderMenusForm;
        }

        //Laden van menuitems per kaart in listview
        private void GetMenus()
        {
            menuList = new List<MenuItem>();
            mlistviewMenu.Items.Clear();

            //Drank kaart
            if (sort == "Drinks")
            {
                mlblSoortBestelling.Text = "Dranken";
                Menu_Service menuService = new Menu_Service();
                menuList = menuService.GetDrinks();

                //Lunch kaart
            }
            else if (sort == "Lunch")
            {
                mlblSoortBestelling.Text = "Lunch";
                Menu_Service menuService = new Menu_Service();
                menuList = menuService.GetLunch();

                //Diner kaart
            }
            else if (sort == "Diner")
            {
                mlblSoortBestelling.Text = "Diner";
                Menu_Service menuService = new Menu_Service();
                menuList = menuService.GetDiner();

            }

            foreach (MenuItem m in menuList)
            {
                ListViewItem li = new ListViewItem(m.naam);
                mlistviewMenu.Items.Add(li);

            }
            mlistviewMenu.View = View.Details;
            //mlistviewMenu.Columns.Add("Naam");
        }

        //Button events
        //private void btnAddItem_Click(object sender, EventArgs e)
        //{
        //    //Selecteerde item aantal verhogen
        //    int amount = int.Parse(mlistviewMenu.SelectedItems[0].SubItems[1].Text);
        //    amount++;
        //    mlistviewMenu.SelectedItems[0].SubItems[1].Text = amount.ToString();

        //}


        //private void btnRemoveItem_Click(object sender, EventArgs e)
        //{
        //    //Selecteerde item aantal verlagen
        //    int amount = int.Parse(mlistviewMenu.SelectedItems[0].SubItems[1].Text);
        //    if (amount == 0)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        amount--;
        //    }
        //    mlistviewMenu.SelectedItems[0].SubItems[1].Text = amount.ToString();
        //}

        //private void btnAddOrder_Click(object sender, EventArgs e)
        //{
        //    int i;
        //    foreach (ListViewItem li in mlistviewMenu.Items)
        //    {
        //        OrderItem o;
        //        MenuItem m = new MenuItem();

        //        m.naam = li.SubItems[0].Text;
        //        string a = "";
        //        a = li.SubItems[1].Text;
        //        i = int.Parse(a);
        //        if (i != 0)
        //        {
        //            bool duplicate;
        //            duplicate = false;
        //            m = menuService.GetItem(m.naam);

        //            o = new OrderItem();
        //            o.menuItem = m;
        //            o.Aantal = i;
        //            o.Status = "bezig";

        //            //orderitems toevoegen aan lijst met orders van het ordermenusform
        //            foreach (OrderItem item in orderMenusForm.bestelling.orderItems)
        //            {
        //                if (item.menuItem.naam == o.menuItem.naam)
        //                {
        //                    duplicate = true;
        //                    item.Aantal += o.Aantal;
        //                }
        //                //continue;
        //            }
        //            if (duplicate == false)
        //            {
        //                orderMenusForm.bestelling.orderItems.Add(o);
        //            }
        //        }

        //    }
        //    MessageBox.Show("Er zijn items aan de bestelling toegevoegd.");
        //    this.Close();
        //    orderMenusForm.Show();
        //    orderMenusForm.LoadOrder();
        //}

        private void OrderForm2_Load(object sender, EventArgs e)
        {
            GetMenus();

            mlblTafel.Text = "Tafel: " + tafelnummer;
            mlblWerknemer.Text = werknemer.naam;
        }

        private void MbtnTerug_Click(object sender, EventArgs e)
        {
            OrderMenusForm2 form = new OrderMenusForm2(werknemer, tafelnummer);
            this.Close();
            form.Show();
        }

        private void MbtnUitloggen_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}

