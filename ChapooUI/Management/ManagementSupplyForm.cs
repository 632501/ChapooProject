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

namespace ChapooUI
{
    public partial class ManagementSupplyForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private Menu_Service menuService = new Menu_Service();
        private List<MenuItem> menu;
        Inlog werknemer = new Inlog();

        public ManagementSupplyForm(Inlog inlog)
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            werknemer = inlog;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagementSupplyForm_Load(object sender, EventArgs e)
        {
            GetMenu();
            DisplayListView(menu);

            HideAllControls();
        }

        private void ListView_ViewSupply_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuItem menuItem = new MenuItem();

            if (werknemer.functie == "Manager")
            {
                if (ListView_ViewSupply.SelectedItems.Count > 0)
                {
                    menuItem = (MenuItem)ListView_ViewSupply.SelectedItems[0].Tag;
                }

                ShowAllControls();

                lbl_SelectedName.Text = menuItem.naam;
                txt_SelectedAmount.Text = menuItem.voorraad.ToString();
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            string name = lbl_SelectedName.Text;
            int amount = int.Parse(txt_SelectedAmount.Text);

            menuService.ChangeSupply(name, amount);

            GetMenu();
            DisplayListView(menu);
            lbl_SelectedName.Text = "";
            txt_SelectedAmount.Clear();

            HideAllControls();

            MessageBox.Show("U heeft de voorraad van het item '" + name + "' veranderd naar " + amount);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(txt_SelectedAmount.Text);
            txt_SelectedAmount.Text = (amount + 100).ToString();
        }

        private void btn_MinHonderd_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(txt_SelectedAmount.Text);
            txt_SelectedAmount.Text = (amount - 100).ToString();
        }

        private void btn_MinTen_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(txt_SelectedAmount.Text);
            txt_SelectedAmount.Text = (amount - 10).ToString();
        }

        private void btn_MinOne_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(txt_SelectedAmount.Text);
            txt_SelectedAmount.Text = (amount - 1).ToString();
        }

        private void btn_PlusOne_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(txt_SelectedAmount.Text);
            txt_SelectedAmount.Text = (amount + 1).ToString();
        }

        private void btn_PlusTen_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(txt_SelectedAmount.Text);
            txt_SelectedAmount.Text = (amount + 10).ToString();
        }

        private void GetMenu()
        {
            menu = menuService.GetMenu();
        }

        private void DisplayListView(List<MenuItem> menu)
        {
            ListView_ViewSupply.Items.Clear();

            ListView_ViewSupply.View = View.Details;
            foreach (MenuItem item in menu)
            {

                ListViewItem me = new ListViewItem(item.menu_ID.ToString());
                me.SubItems.Add(item.naam);
                me.SubItems.Add(item.categorie);
                me.SubItems.Add(item.voorraad.ToString());
                me.Tag = item;

                ListView_ViewSupply.Items.Add(me);
            }
        }

        public void HideAllControls()
        {
            lbl_SelectedName.Hide();
            txt_SelectedAmount.Hide();
            btn_Change.Hide();
            btn_MinHundred.Hide();
            btn_MinOne.Hide();
            btn_MinTen.Hide();
            btn_PlusHundred.Hide();
            btn_PlusOne.Hide();
            btn_PlusTen.Hide();
        }

        public void ShowAllControls()
        {
            lbl_SelectedName.Show();
            txt_SelectedAmount.Show();
            btn_Change.Show();
            btn_MinHundred.Show();
            btn_MinOne.Show();
            btn_MinTen.Show();
            btn_PlusHundred.Show();
            btn_PlusOne.Show();
            btn_PlusTen.Show();
        }
    }   
}
