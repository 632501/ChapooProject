﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using ChapooDAL;
using ChapooModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooUI
{
    public partial class LoginForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public LoginForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
           
            //password characters
            txt_Password.PasswordChar = '*';
            
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        //zorgen dat de buttons een string invoeren met opklikken
        private void btn_Nr1_Click(object sender, EventArgs e)
        {
            txt_Password.Text += "1";
        }

        private void btn_Nr2_Click(object sender, EventArgs e)
        {
            txt_Password.Text += "2";
        }

        private void btn_Nr3_Click(object sender, EventArgs e)
        {
            txt_Password.Text += "3";
        }

        private void btn_Nr4_Click(object sender, EventArgs e)
        {
            txt_Password.Text += "4";
        }

        private void btn_Nr5_Click(object sender, EventArgs e)
        {
            txt_Password.Text += "5";
        }

        private void btn_Nr6_Click(object sender, EventArgs e)
        {
            txt_Password.Text += "6";
        }

        private void btn_Nr7_Click(object sender, EventArgs e)
        {
            txt_Password.Text += "7";
        }

        private void btn_Nr8_Click(object sender, EventArgs e)
        {
            txt_Password.Text += "8";
        }

        private void btn_Nr9_Click(object sender, EventArgs e)
        {
            txt_Password.Text += "9";
        }

        private void btn_Nr0_Click(object sender, EventArgs e)
        {
            txt_Password.Text += "0";
        }

        private void btn_Backspace_Click(object sender, EventArgs e)
        {
            string s = txt_Password.Text;

            if (s.Length >= 1)
            {
                s = s.Substring(0, s.Length - 1);
            }

            txt_Password.Text = s;
        }

        private void btn_inlog_Click(object sender, EventArgs e)
        {
            Login_DAO login_dao = new Login_DAO();
            Inlog login = new Inlog();

            string password = txt_Password.Text;

            //if (login_dao.Login(password) == true && login.functie == "manager")
            //{
            //    this.Hide();
            //    ManagementActionForm management = new ManagementActionForm();
            //    management.Show();
            //}
            //else if (login_dao.Login(password) == true && login.functie == "barman" || login.functie == "kok")
            //{
            //    this.Hide();
            //    KitchenActionForm kitchenAndBar = new KitchenActionForm(login);
            //    kitchenAndBar.Show();
            //}
           /* else*/ if (login_dao.Login(password) == true /*&& login.functie == "Bediening"*/)
            {
                this.Hide();
                TableForm table = new TableForm(login);
                table.Show();
            }
            else
            {
                lbl_IncorrectPassword.ForeColor = Color.Red;
                lbl_IncorrectPassword.Text = "Incorrect wachtwoord, probeer opnieuw";
                txt_Password.Clear();
            }

            
        }
    }
}
