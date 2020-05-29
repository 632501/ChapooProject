using MaterialSkin;
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
using ChapooModel.Models;
using ChapooLogica;

namespace ChapooUI
{
    public partial class TableForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        Button[] btnList;
        Inlog werknemer = new Inlog();
        public List<Tafel> tables;
        public string orders;
        Tafel_Service tafelService = new Tafel_Service();


        public TableForm(Inlog inlog)
        {
            InitializeComponent();


            mlblWerknemer.Text = inlog.naam;
            werknemer = inlog;

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            btnList = new Button[10] { btn_Tafel1, btn_Tafel2, btn_Tafel3, btn_Tafel4, btn_Tafel5, btn_Tafel6, btn_Tafel7, btn_Tafel8, btn_Tafel9, btn_Tafel10 };
        }

        private void TafelForm_Load(object sender, EventArgs e)
        {

            //Inlog_DAO inlog_DAO = new Inlog_DAO();
            //BestelGerecht_DAO gerecht = new BestelGerecht_DAO();

            tables = tafelService.getTables();
            

            SetTableColors();
            //btnList[6].BackColor = Color.Yellow;
            //btnList[8].BackColor = Color.Orange;

        }

        public void SetTableColors()
        {
            for (int i = 0; i < tables.Count; i++)
            {
                orders = tafelService.CheckOrderStatus(i+1);
                if (tables[i].bezet == false)
                {
                    btnList[i].BackColor = Color.Green;
                }
                else if (tables[i].bezet == true && (orders == "bezig" || orders == "Bezig"))
                {
                    btnList[i].BackColor = Color.Orange;
                    
                } else if (tables[i].bezet == true && orders == "Gereed")
                {
                    btnList[i].BackColor = Color.Red;
                } else if (orders == "" || orders == " ")
                {
                    tafelService.EditStatus(i, false);
                    btnList[i].BackColor = Color.Green;
                }
            }
        }

        public void Occupied(int tafelnummer)
        {
            List<Tafel> tafels = tafelService.getTables();

            if (tafels[tafelnummer-1].bezet ==  true)
            {
                this.Close();
                OrderActionForm2 orderForm = new OrderActionForm2(werknemer, tafelnummer);
                orderForm.Show();
            } else
            {
                DialogResult dialogResult = MessageBox.Show("Wil je deze tafel op bezet zetten?", "Bezet zetten", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    tafelService.EditStatus(tafelnummer, true);
                    this.Close();
                    OrderActionForm2 orderForm = new OrderActionForm2(werknemer, tafelnummer);
                    orderForm.Show();
                }
            }
        }

        private void btn_Tafel9_Click(object sender, EventArgs e)
        {
            Occupied(9);
        }

        private void btn_Tafel10_Click(object sender, EventArgs e)
        {
            Occupied(10);
        }

        private void btn_Tafel8_Click(object sender, EventArgs e)
        {
            Occupied(8);
        }

        private void btn_Tafel7_Click(object sender, EventArgs e)
        {
            Occupied(7);
        }

        private void btn_Tafel6_Click(object sender, EventArgs e)
        {
            Occupied(6);
        }

        private void btn_Tafel5_Click(object sender, EventArgs e)
        {
            Occupied(5);
        }

        private void btn_Tafel4_Click(object sender, EventArgs e)
        {
            Occupied(4);
        }

        private void btn_Tafel3_Click(object sender, EventArgs e)
        {
            Occupied(3);
        }

        private void btn_Tafel2_Click(object sender, EventArgs e)
        {
            Occupied(2);
        }

        private void btn_Tafel1_Click(object sender, EventArgs e)
        {
            Occupied(1);
        }

        private void btn_Uitlog_Click(object sender, EventArgs e)
        {
            
        }

        private void MbtnUitloggen_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}

