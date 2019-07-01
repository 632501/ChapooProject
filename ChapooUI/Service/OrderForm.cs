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

namespace ChapooUI
{
    public partial class OrderForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private string sort { get; set; }
        private List<MenuItem> menuList { get; set; }
       
        private int tafelnummer { get; set; }
        Bestelling order { get; set; }
        Inlog werknemer { get; set; }
        Bestelling_Service bestellingService = new Bestelling_Service();
        Menu_Service menuService = new Menu_Service();
        OrderMenusForm orderMenusForm { get; set; }

        public OrderForm(string sort, int tafelnummer, Bestelling order, Inlog werknemer, OrderMenusForm orderMenusForm)
        {
            this.sort = sort;
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.order = order;
            this.tafelnummer = tafelnummer;
            this.werknemer = werknemer;
            this.orderMenusForm = orderMenusForm;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            GetMenus();

            lbl_Table.Text = "Tafel: " + tafelnummer;
            mlblWerknemer.Text = werknemer.naam;
        }

        private void listviewMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        //Laden van menuitems per kaart in listview
        private void GetMenus()
        {
            int amount = 0;
            menuList = new List<MenuItem>();

            listviewMenu.Items.Clear();
            
            //Drank kaart
            if (sort == "Drinks")
            {
                mlblSoortBestelling.Text = "Dranken";
                Menu_Service menuService = new Menu_Service();
                menuList = menuService.GetDrinks();

            //Lunch kaart
            } else if (sort == "Lunch")
            {
                mlblSoortBestelling.Text = "Lunch";
                Menu_Service menuService = new Menu_Service();
                menuList = menuService.GetLunch();
            
            //Diner kaart
            } else if (sort == "Diner")
            {
                mlblSoortBestelling.Text = "Diner";
                Menu_Service menuService = new Menu_Service();
                menuList = menuService.GetDiner();

            }

            foreach (MenuItem m in menuList)
            {
                ListViewItem li = new ListViewItem(m.naam);
                li.SubItems.Add(amount.ToString());
                listviewMenu.Items.Add(li);

            }
            listviewMenu.View = View.Details;
            listviewMenu.Columns.Add("Naam");
            listviewMenu.Columns.Add("Aantal");
        }

        //Button events
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //Selecteerde item aantal verhogen
            int amount = int.Parse(listviewMenu.SelectedItems[0].SubItems[1].Text);
            amount++;
            listviewMenu.SelectedItems[0].SubItems[1].Text = amount.ToString();

        }
        

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            //Selecteerde item aantal verlagen
            int amount = int.Parse(listviewMenu.SelectedItems[0].SubItems[1].Text);
            if (amount == 0)
            {
                return;
            } else
            {
                amount--;
            }
            listviewMenu.SelectedItems[0].SubItems[1].Text = amount.ToString();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            int i;
            foreach (ListViewItem li in listviewMenu.Items)
            {
                OrderItem o;
                MenuItem m = new MenuItem();

                m.naam = li.SubItems[0].Text;
                string a = "";
                a = li.SubItems[1].Text;
                i = int.Parse(a);
                if (i != 0)
                {
                    bool duplicate;
                    duplicate = false;
                    m = menuService.GetItem(m.naam);
                    
                    o = new OrderItem();
                    o.menuItem = m;
                    o.Aantal = i;
                    o.Status = "bezig";

                    //orderitems toevoegen aan lijst met orders van het ordermenusform
                    foreach (OrderItem item in orderMenusForm.bestelling.orderItems)
                    {
                        if (item.menuItem.naam == o.menuItem.naam)
                        {
                            duplicate = true;
                            item.Aantal += o.Aantal;
                        } 
                        continue;
                    }
                    if (duplicate == false)
                    {
                        orderMenusForm.bestelling.orderItems.Add(o);
                    }
                }
                
            }
            MessageBox.Show("Er zijn items aan de bestelling toegevoegd.");
            this.Close();
            orderMenusForm.Show();
            orderMenusForm.LoadOrder();
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            OrderMenusForm form = new OrderMenusForm(werknemer, tafelnummer);
            this.Close();
            form.Show();
        }
    }
}
