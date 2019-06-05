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

        public OrderActionForm()
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

        private void btnActionOpnemen_Click(object sender, EventArgs e)
        {
            OrderMenusForm orderMenusForm = new OrderMenusForm();
        }
    }
}
