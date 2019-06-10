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
    public partial class ManagementActionForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private Inlog inlog;
        public ManagementActionForm(Inlog inlog)
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.inlog = inlog;
        }

        private void btn_Supply_Click(object sender, EventArgs e)
        {
            ManagementSupplyForm supplyForm = new ManagementSupplyForm();
            supplyForm.ShowDialog();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            ManagementMenuForm menuForm = new ManagementMenuForm();
            menuForm.ShowDialog();
        }

        private void btn_EmployeeFiles_Click(object sender, EventArgs e)
        {
            ManagementEmployeeForm EmployeeForm = new ManagementEmployeeForm();
            EmployeeForm.ShowDialog();
        }

        private void ManagementActionForm_Load(object sender, EventArgs e)
        {
            lbl_name.Text = inlog.naam;
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm form = new LoginForm();
            form.ShowDialog();

            
        }
    }
}
