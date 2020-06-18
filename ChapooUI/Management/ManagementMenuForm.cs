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
using ChapooModel;
using ChapooLogica;
using MenuItem = ChapooModel.MenuItem;
using System.Globalization;

namespace ChapooUI
{
    public partial class ManagementMenuForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private Menu_Service menuService = new Menu_Service();
        private List<MenuItem> menu;

        public ManagementMenuForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagementMenuForm_Load(object sender, EventArgs e)
        {
            GetMenu();
            DisplayListView(menu);

            HideAllControlls();
        }

        private void ListView_ViewMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuItem menuItem = new MenuItem();

            ShowExistingListViewItems();

            if (ListView_ViewMenu.Items[0].Selected)
            {
                ClearAllTextFields();

                lbl_Supply.Show();
                txt_Supply.Show();
                btn_Remove.Hide();

                NextID();
            }
            else
            {
                txt_Supply.Hide();
                lbl_Supply.Hide();
                txt_Btw.Hide();
                lbl_btw.Hide();
                label1.Hide();

                if (ListView_ViewMenu.SelectedItems.Count > 0)
                {
                    menuItem = (MenuItem)ListView_ViewMenu.SelectedItems[0].Tag;
                    txt_ItemID.Text = menuItem.menu_id.ToString();
                    txt_ItemNaam.Text = menuItem.naam;
                    txt_ItemCategorie.Text = menuItem.categorie;
                    txt_ItemPrijs.Text = menuItem.prijs.ToString().Replace(',', '.');
                }
            }
        }

        private void txt_Supply_TextChanged(object sender, EventArgs e)
        {
            OnlyNumbersAllowed(txt_Supply);
        }

        private void txt_ItemPrijs_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_Btw_TextChanged(object sender, EventArgs e)
        {
            OnlyNumbersAllowed(txt_Btw);
        }

        private void txt_ItemID_TextChanged(object sender, EventArgs e)
        {
            OnlyNumbersAllowed(txt_ItemID);

            if (ListView_ViewMenu.Items[0].Selected)
            {
                
            }
            else
            {
                MenuItem item = new MenuItem();

                if (ListView_ViewMenu.SelectedItems.Count > 0)
                {
                    item = (MenuItem)ListView_ViewMenu.SelectedItems[0].Tag;
                }

                txt_ItemID.Text = item.menu_id.ToString();
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(txt_ItemID.Text);
                string naam = txt_ItemNaam.Text;
                string prijs = txt_ItemPrijs.Text;
                string categorie = txt_ItemCategorie.Text.ToLower();
                
                if (CategoryCheck(categorie))
                {
                    return;
                }

                if (ListView_ViewMenu.Items[0].Selected)
                {
                    int voorraad = int.Parse(txt_Supply.Text);
                    int btw = int.Parse(txt_Btw.Text);

                    menuService.AddMenuItem(ID, naam, prijs, categorie, voorraad, btw);
                }

                menuService.ChangeMenu(ID, naam, prijs, categorie);
            }
            catch { MessageBox.Show("Oeps! Er is een verkeerde invoer gegeven..."); return; }

            GetMenu();
            DisplayListView(menu);

            HideAllControlls();
            ClearAllTextFields();

            rbtn_ID.Checked = true;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txt_ItemID.Text);

            menuService.RemoveItem(ID);

            GetMenu();
            DisplayListView(menu);

            HideAllControlls();
            ClearAllTextFields();

            rbtn_ID.Checked = true;
        }




        private void GetMenu()
        {
            menu = menuService.GetMenu();
        }

        private void DisplayListView(List<MenuItem> menu)
        {
            ListView_ViewMenu.Items.Clear();

            ListView_ViewMenu.View = View.Details;
            ListViewItem add = new ListViewItem("--");
            add.SubItems.Add("Klik hier om een nieuw menu item toe te voegen");
            add.SubItems.Add("+");
            ListView_ViewMenu.Items.Add(add);
            foreach (MenuItem item in menu)
            {

                ListViewItem me = new ListViewItem(item.menu_id.ToString());
                me.SubItems.Add(item.naam);
                me.SubItems.Add(item.prijs.ToString("#.##"));
                me.SubItems.Add(item.categorie);
                me.Tag = item;

                ListView_ViewMenu.Items.Add(me);
            }
        }

        private void HideAllControlls()
        {
            txt_ItemID.Hide();
            txt_ItemCategorie.Hide();
            txt_ItemNaam.Hide();
            txt_ItemPrijs.Hide();
            txt_Supply.Hide();
            lbl_Category.Hide();
            lbl_ItemID.Hide();
            lbl_ItemName.Hide();
            lbl_Prijs.Hide();
            lbl_Supply.Hide();
            btn_Change.Hide();
            btn_Remove.Hide();
            txt_Btw.Hide();
            lbl_btw.Hide();
            label1.Hide();
            label2.Hide();
        }

        private void ShowExistingListViewItems()
        {
            txt_ItemID.Show();
            txt_ItemCategorie.Show();
            txt_ItemNaam.Show();
            txt_ItemPrijs.Show();
            lbl_Category.Show();
            lbl_ItemID.Show();
            lbl_ItemName.Show();
            lbl_Prijs.Show();
            btn_Change.Show();
            btn_Remove.Show();
            lbl_btw.Show();
            txt_Btw.Show();
            label1.Show();
            label2.Show();
        }

        private void ClearAllTextFields()
        {
            txt_ItemID.Clear();
            txt_ItemCategorie.Clear();
            txt_ItemNaam.Clear();
            txt_ItemPrijs.Clear();
            txt_Supply.Clear();
            txt_Btw.Clear();
        }

        private void OnlyNumbersAllowed(TextBox textBox)
        {
            foreach (char ch in textBox.Text)
            {
                if (!Char.IsNumber(ch))
                {
                    MessageBox.Show("U kunt hier alleen positieve cijfers invoeren of '0'...");
                    textBox.Text = "";
                    
                }
            }
        }

        private void NextID()
        {
            int nextMenuID;

            nextMenuID = menu.Count()+1;

            txt_ItemID.Text = nextMenuID.ToString();
        }
        private bool CategoryCheck(string category)
        {
            if(category.ToLower() != "dranken" && category.ToLower() != "lunch" && category.ToLower() != "diner")
            {
                MessageBox.Show("De categorie kan alleen 'dranken', 'lunch', 'diner' zijn...");
                txt_ItemCategorie.Text = "";
                return true;
            }
            return false;
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            List<string> sortedListNames = new List<string>();
            List<MenuItem> sortedList = new List<MenuItem>();
            foreach(MenuItem item in menu)
            {
                sortedListNames.Add(item.naam);
            }
            sortedListNames.Sort();
            foreach(string name in sortedListNames)
            {
                foreach(MenuItem item in menu)
                {
                    if(name == item.naam)
                    {
                        sortedList.Add(item);
                    }
                }
            }
            DisplayListView(sortedList);
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void rbtn_ID_CheckedChanged(object sender, EventArgs e)
        {
            List<int> sortedListID = new List<int>();
            List<MenuItem> sortedList = new List<MenuItem>();
            foreach (MenuItem item in menu)
            {
                sortedListID.Add(item.menu_id);
            }
            sortedListID.Sort();
            foreach (int name in sortedListID)
            {
                foreach (MenuItem item in menu)
                {
                    if (name == item.menu_id)
                    {
                        sortedList.Add(item);
                    }
                }
            }
            DisplayListView(sortedList);
        }

        private void rbtn_Prijs_CheckedChanged(object sender, EventArgs e)
        {
            List<MenuItem> sortedList = new List<MenuItem>();
            sortedList = menu;
            sortedList.Sort((x, y) => decimal.Compare(x.prijs, y.prijs));
            DisplayListView(sortedList);
        }

        private void rbtn_Categorie_CheckedChanged(object sender, EventArgs e)
        {
            List<MenuItem> sortedList = new List<MenuItem>();
            sortedList = menu;
            sortedList.Sort((x, y) => string.Compare(x.categorie, y.categorie));
            DisplayListView(sortedList);
        }
    }
}

