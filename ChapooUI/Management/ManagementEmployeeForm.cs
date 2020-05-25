using ChapooModel;
using ChapooLogica;
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
    public partial class ManagementEmployeeForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        Login_Service inlogService = new Login_Service();
        private List<Inlog> employeeList = new List<Inlog>();


        public ManagementEmployeeForm()
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

        private void ManagementEmployeeForm_Load(object sender, EventArgs e)
        {
            GetEmployeeList();
            DisplayListView(employeeList);

            HideAllControlls();
        }

        private void ListView_Employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inlog werknemer = new Inlog();

            ShowAllControlls();

            if (ListView_Employee.Items[0].Selected)
            {
                ClearAllTextFields();

                btn_Remove.Hide();
                NextID();
            }
            else
            {
                if (ListView_Employee.SelectedItems.Count > 0)
                {
                    werknemer = (Inlog)ListView_Employee.SelectedItems[0].Tag;

                    txt_ID.Text = werknemer.werknemer_id.ToString();
                    txt_Name.Text = werknemer.naam;
                    txt_Function.Text = werknemer.functie;
                    txt_Password.Text = werknemer.wachtwoord;
                }
              
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txt_ID.Text);
            string name = txt_Name.Text;
            string password = txt_Password.Text;
            string function = txt_Function.Text.ToLower();

            if (FunctionCheck(function) || PasswordCheck(password))
            {
                return;
            }

            if (ListView_Employee.Items[0].Selected)
            {
                inlogService.AddEmployee(ID, name, password, function);
            }
            else
            {
                inlogService.ChangeEmployee(ID, name, password, function);
            }

            GetEmployeeList();
            DisplayListView(employeeList);

            HideAllControlls();
            ClearAllTextFields();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txt_ID.Text);
            string name = txt_Name.Text;
            string password = txt_Password.Text;
            string function = txt_Function.Text;

            inlogService.FireEmployee(ID);

            GetEmployeeList();
            DisplayListView(employeeList);

            HideAllControlls();
            ClearAllTextFields();
        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {
            if (ListView_Employee.Items[0].Selected)
            {
                OnlyNumbersAllowed(txt_ID);
            }
            else
            {
                Inlog employee = new Inlog();

                if (ListView_Employee.SelectedItems.Count > 0)
                {
                    employee = (Inlog)ListView_Employee.SelectedItems[0].Tag;
                }

                txt_ID.Text = employee.werknemer_id.ToString();
            }
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            OnlyNumbersAllowed(txt_Password);

        }




        private void DisplayListView(List<Inlog> employeeList)
        {
            ListView_Employee.Items.Clear();

            ListView_Employee.View = View.Details;
            ListViewItem add = new ListViewItem("--");
            add.SubItems.Add("Klik hier om een nieuwe werknemer toetevoegen +");
            add.SubItems.Add("--");
            add.SubItems.Add("--");
            ListView_Employee.Items.Add(add);
            foreach (Inlog werknemer in employeeList)
            {

                ListViewItem em = new ListViewItem(werknemer.werknemer_id.ToString());
                em.SubItems.Add(werknemer.naam);
                em.SubItems.Add(werknemer.wachtwoord);
                em.SubItems.Add(werknemer.functie);
                em.Tag = werknemer;

                ListView_Employee.Items.Add(em);
            }
        }

        private void GetEmployeeList()
        {
            employeeList = inlogService.GetEmployeeList();
        }

        private void HideAllControlls()
        {
            txt_Function.Hide();
            txt_ID.Hide();
            txt_Name.Hide();
            txt_Password.Hide();
            lbl_Function.Hide();
            lbl_ID.Hide();
            lbl_Name.Hide();
            lbl_Password.Hide();
            btn_Change.Hide();
            btn_Remove.Hide();
        }

        private void ShowAllControlls()
        {
            txt_Function.Show();
            txt_ID.Show();
            txt_Name.Show();
            txt_Password.Show();
            lbl_Function.Show();
            lbl_ID.Show();
            lbl_Name.Show();
            lbl_Password.Show();
            btn_Change.Show();
            btn_Remove.Show();
        }

        private void ClearAllTextFields()
        {
            txt_Password.Clear();
            txt_Name.Clear();
            txt_ID.Clear();
            txt_Function.Clear();
        }

        public bool FunctionCheck(string function)
        {
            if (function.ToLower() != "kok" && function.ToLower() != "bediening" && function.ToLower() != "barman" && function.ToLower() != "manager")
            {
                MessageBox.Show("De categorie kan alleen 'bediening', 'kok', 'barman' of 'manager' zijn...");
                txt_Function.Text = "";
                return true;
            }
            return false;
        }

        public bool PasswordCheck(string password)
        {
            int count = password.Count();
            if(count != 4)
            {
                MessageBox.Show("Het wachtwoord moet uit 4 cijfers bestaan");
                txt_Password.Text = "";
                return true;
            }
            return false;
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
            int nextEmployeeID;

            nextEmployeeID = employeeList[employeeList.Count - 1].werknemer_id + 1;

            txt_ID.Text = nextEmployeeID.ToString();
        }
    }
}
