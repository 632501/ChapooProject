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
    public partial class OrderMenusForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public OrderMenusForm()
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

        }

        private void listviewMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void OrderMenusForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            OrderForm drinksForm = new OrderForm();
            drinksForm.GetOrder("Drinks")
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            OrderForm lunchForm = new OrderForm();
            lunchForm.GetOrder("Lunch");
        }

        private void btnDiner_Click(object sender, EventArgs e)
        {
            OrderForm dinerForm = new OrderForm();
            dinerForm.GetOrder("Diner");
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {

        }
    }
}
