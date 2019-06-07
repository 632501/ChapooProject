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
                
            
            

            //if (table_dao.Occupied(1) == true)
            //{
            //    btn_Tafel1.BackColor = Color.Green;
            //}
            //else if (table_dao.Occupied(1) == false)
            //{
            //    btn_Tafel1.BackColor = Color.Red;
            //}
            ////Tafel 2 kleuren
            //if (table_dao.Occupied(2) == true)
            //{
            //    btn_Tafel2.BackColor = Color.Green;
            //}
            //else if (table_dao.Occupied(2) == false)
            //{
            //    btn_Tafel2.BackColor = Color.Red;
            //}
            ////tafel 3 kleuren
            //if (table_dao.Occupied(3) == true)
            //{
            //    btn_Tafel3.BackColor = Color.Green;
            //}
            //else if (table_dao.Occupied(3) == false)
            //{
            //    btn_Tafel3.BackColor = Color.Red;
            //}
            ////tafel 4 kleuren
            //if (table_dao.Occupied(4) == true)
            //{
            //    btn_Tafel4.BackColor = Color.Green;
            //}
            //else if (table_dao.Occupied(4) == false)
            //{
            //    btn_Tafel4.BackColor = Color.Red;
            //}
            //// tafel 5 kleuren
            //if (table_dao.Occupied(5) == true)
            //{
            //    btn_Tafel5.BackColor = Color.Green;
            //}
            //else if (table_dao.Occupied(5) == false)
            //{
            //    btn_Tafel5.BackColor = Color.Red;
            //}
            ////tafel 6 kleuren
            //if (table_dao.Occupied(6) == true)
            //{
            //    btn_Tafel6.BackColor = Color.Green;
            //}
            //else if (table_dao.Occupied(6) == false)
            //{
            //    btn_Tafel6.BackColor = Color.Red;
            //}
            ////tafel 7 kleuren 
            //if (table_dao.Occupied(7) == true)
            //{
            //    btn_Tafel7.BackColor = Color.Green;
            //}
            //else if (table_dao.Occupied(7) == false)
            //{
            //    btn_Tafel7.BackColor = Color.Red;
            //}
            ////tafel 8 kleuren
            //if (table_dao.Occupied(8) == true)
            //{
            //    btn_Tafel8.BackColor = Color.Green;
            //}
            //else if (table_dao.Occupied(8) == false)
            //{
            //    btn_Tafel8.BackColor = Color.Red;
            //}
            ////tafel 9 kleuren
            //if (table_dao.Occupied(9) == true)
            //{
            //    btn_Tafel9.BackColor = Color.Green;
            //}
            //else if (table_dao.Occupied(9) == false)
            //{
            //    btn_Tafel9.BackColor = Color.Red;
            //}
            ////tafel 10
            //if (table_dao.Occupied(10) == true)
            //{
            //    btn_Tafel10.BackColor = Color.Green;
            //}
            //else if (table_dao.Occupied(10) == false)
            //{
            //    btn_Tafel10.BackColor = Color.Red;
            //}
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
