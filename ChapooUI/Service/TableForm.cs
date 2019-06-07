﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using ChapooModel;
using ChapooDAL;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooUI
{
    public partial class TableForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        Button[] btnList;

        public TableForm(Inlog inlog)
        {
            InitializeComponent();

          
            lbl_Naam.Text = inlog.naam;

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            btnList = new Button[10] { btn_Tafel1, btn_Tafel2, btn_Tafel3, btn_Tafel4, btn_Tafel5, btn_Tafel6, btn_Tafel7, btn_Tafel8, btn_Tafel9, btn_Tafel10 };
        }

        private void TafelForm_Load(object sender, EventArgs e)
        {
            Tafel_DAO table_dao = new Tafel_DAO();
            
            //Inlog_DAO inlog_DAO = new Inlog_DAO();

            
            
                for (int i = 0; i < btnList.Length; i++)
                {
                    if (table_dao.Occupied(i + 1)/*(int.Parse(button.ToString()))*/ == true)
                    {
                    //btn_Tafel1.ForeColor = Color.Red;
                    btnList[i].BackColor = Color.Red;
                    }
                    else if (table_dao.Occupied(i + 1)/*(int.Parse(button.ToString()))*/ == false)
                    {
                       btnList[i].BackColor = Color.Green;
                    }
                }
        }

        private void btn_Tafel9_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderActionForm orderForm = new OrderActionForm();
            orderForm.Show();
        }

        private void btn_Tafel10_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderActionForm orderForm = new OrderActionForm();
            orderForm.Show();
        }

        private void btn_Tafel8_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderActionForm orderForm = new OrderActionForm();
            orderForm.Show();
        }

        private void btn_Tafel7_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderActionForm orderForm = new OrderActionForm();
            orderForm.Show();
        }

        private void btn_Tafel6_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderActionForm orderForm = new OrderActionForm();
            orderForm.Show();
        }

        private void btn_Tafel5_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderActionForm orderForm = new OrderActionForm();
            orderForm.Show();
        }

        private void btn_Tafel4_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderActionForm orderForm = new OrderActionForm();
            orderForm.Show();
        }

        private void btn_Tafel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderActionForm orderForm = new OrderActionForm();
            orderForm.Show();
        }

        private void btn_Tafel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderActionForm orderForm = new OrderActionForm();
            orderForm.Show();
        }

        private void btn_Tafel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderActionForm orderForm = new OrderActionForm();
            orderForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderActionForm orderForm = new OrderActionForm();
            orderForm.Show();
        }

        private void btn_Uitlog_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
