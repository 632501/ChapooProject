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
using Menu = ChapooModel.MenuItem;

namespace ChapooUI
{
    public partial class OrderForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public OrderForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            GetOrder();
        }

        private void listviewMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    
        public void GetOrder()
        {
            mlblSoortBestelling.Text = "Drinken";
            Menu_Service menuService = new Menu_Service();
            List<Menu> menuList = menuService.GetDrinks();

            listviewMenu.Items.Clear();

            foreach (Menu m in menuList)
            {
                ListViewItem li = new ListViewItem(m.naam);
                li.Tag = m;
                listviewMenu.Items.Add(li);

            }
            listviewMenu.View = View.Details;
            listviewMenu.Columns.Add("Naam");
        }
    }
}
