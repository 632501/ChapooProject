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
            listviewMenu.Items.Clear();

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
                listviewMenu.Items.Add(li);
                li.Tag = m;
                li.ToolTipText = m.naam;
            }
            listviewMenu.View = View.Details;
            listviewMenu.Columns.Add("Naam");
            listviewMenu.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        }

        private void OrderForm2_Load(object sender, EventArgs e)
        {
            GetMenus();

            mlblTafel.Text = "Tafel: " + tafelnummer;
            mlblWerknemer.Text = werknemer.naam;
        }

        private void MbtnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
            orderMenusForm.Show();
            orderMenusForm.LoadOrder();
        }

        private void MbtnUitloggen_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void ListviewMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listviewMenu.SelectedItems.Count > 0)
            {
                MenuItem item = new MenuItem();
                item = (MenuItem)listviewMenu.SelectedItems[0].Tag;
                //Open form die shit toevoegd.
                OrderMenuAddForm form = new OrderMenuAddForm(item, orderMenusForm, this);
                form.Show();
            }
        }
    }
}

