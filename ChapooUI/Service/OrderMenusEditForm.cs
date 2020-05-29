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
using MenuItem = ChapooModel.MenuItem;
using ChapooModel.Models;


namespace ChapooUI.Service
{
    public partial class OrderMenusEditForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        OrderItem item;
        int itemvoorraad;
        OrderMenusForm2 form;
        Order_Service orderService = new Order_Service();
        Menu_Service menuService = new Menu_Service();
        public OrderMenusEditForm(OrderItem item, OrderMenusForm2 form)
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.form = form;
            this.item = item;
            itemvoorraad = item.menuItem.voorraad;
        }

        private void OrderMenuEditForm_Load(object sender, EventArgs e)
        {
            mtextCommentaar.Text = item.Comment;
            mlblItem.Text = item.menuItem.naam;
            numAantal.Value = item.Aantal;
            int v = item.menuItem.voorraad - item.Aantal;
            mlblVoorraadAantal.Text = v.ToString();
        }

        private void NumAantal_ValueChanged(object sender, EventArgs e)
        {
            int aantal = Convert.ToInt32(numAantal.Value);

            int voorraad = itemvoorraad - aantal;
            mlblVoorraadAantal.Text = voorraad.ToString();
        }

        //private void MbtnVerwijderen_Click(object sender, EventArgs e)
        //{
        //    int id = item.order_id;
        //    DialogResult res = MessageBox.Show("Weet je het zeker dat je deze orderitem wilt verwijderen?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //    if (res == DialogResult.OK)
        //    {
        //        int voorraad = item.menuItem.voorraad + item.Aantal;
        //        orderService.DeleteOrder(item.order_id);
        //        menuService.ChangeSupply(item.menuItem.naam, voorraad );
        //        form.LoadOrders();
        //        this.Close();
        //    }
        //    else if (res == DialogResult.Cancel)
        //    {
        //        MessageBox.Show("Verwijderen is afgebroken");
        //    }
        //}

        private void MbtnEdit_Click(object sender, EventArgs e)
        {
            //update orderitem
            OrderItem o = item;
            int aantal = Convert.ToInt32(numAantal.Value);
            string commentaar = mtextCommentaar.Text;
            if (int.Parse(mlblVoorraadAantal.Text) >= 0)
            {
                if (aantal != o.Aantal || commentaar != o.Comment)
                {
                    if (aantal == 0)
                    {
                        //Verwijder orderitem van de lijst
                        //form.bestelling.orderItems[o.order_id].
                        form.bestelling.orderItems.Remove(o);

                    }
                    else
                    {
                        //Verander aantal
                        form.bestelling.orderItems[o.order_id].Aantal = aantal;
                        form.bestelling.orderItems[o.order_id].Comment = commentaar;
                    }
                }
                else
                {
                    MessageBox.Show("Geen aanpassing gevonden, Aanpassen gestopt ");
                }

                this.Close();
                form.LoadOrder();
                form.Show();
            } else
            {
                MessageBox.Show("Niet genoeg voorraad, verminder het gewenste aantal.");
            }
            


            
                //if (aantal > o.Aantal)
                //{
                //    int verschil = aantal - o.Aantal;
                //    int voorraad = o.menuItem.voorraad;
                //    //menuService.ChangeSupply(o.menuItem.naam, voorraad - verschil);
                //    form.bestelling.orderItems[o.order_id].Aantal = 1;
                //} else
                //{
                //    int verschil = aantal - o.Aantal;
                //    int voorraad = o.menuItem.voorraad;
                //    //menuService.ChangeSupply(o.menuItem.naam, voorraad - verschil);

                //}
                //o.Aantal = aantal;
                //o.Comment = commentaar;
                ////form.bestelling.orderItems[o.order_id].Aantal == aantal;
                //// doe update
                ////orderService.EditOrder(o);
                //form.LoadOrders();
                //this.Close();
                //form.Show();
                
            
            
        }

        private void MbtnAfbreken_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toevoegen gestopt");
            this.Close();
            form.Show();
        }
    }
}
