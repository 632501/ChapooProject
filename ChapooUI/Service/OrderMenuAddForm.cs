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
    public partial class OrderMenuAddForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        MenuItem item;
        OrderMenusForm2 orderMenusForm2;
        OrderForm2 orderForm;
        int itemvoorraad;
        public OrderMenuAddForm(MenuItem item, OrderMenusForm2 orderMenusForm2, OrderForm2 orderForm)
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.item = item;
            this.orderMenusForm2 = orderMenusForm2;
            this.orderForm = orderForm;
        }

        private void MbtnToevoegen_Click(object sender, EventArgs e)
        {
            bool duplicate = false;
            string commentaar = mtextCommentaar.Text;
            decimal aantal = numAantal.Value;
            int a = Convert.ToInt32(aantal);
            //toevoeg methode

            if (a != 0)
            {
                if (int.Parse(mlblVoorraadAantal.Text) >= 0)
                {
                    OrderItem o = new OrderItem();
                    o.menuItem = item;
                    o.Aantal = a;
                    o.Status = "bezig";
                    o.Comment = commentaar;
                    foreach (OrderItem item in orderMenusForm2.bestelling.orderItems)
                    {
                        if (item.menuItem.naam == o.menuItem.naam)
                        {
                            duplicate = true;
                            item.Aantal = item.Aantal + o.Aantal;
                            item.Comment = item.Comment + o.Comment;
                        }


                    }

                    if (duplicate == false)
                    {
                        orderMenusForm2.bestelling.orderItems.Add(o);
                    }
                    MessageBox.Show("Er zijn items aan de bestelling toegevoegd");
                    this.Close();
                    orderForm.Close();
                    orderMenusForm2.Show();
                    orderMenusForm2.LoadOrder();
                }
                else
                {
                    MessageBox.Show("Te weinig in voorraad om zoveel te bestellen.");
                }
                }
                else
                {
                    MessageBox.Show("Aantal kan niet nul zijn.");
                }
            }
        

        private void OrderMenuAddForm_Load(object sender, EventArgs e)
        {
            mlblItem.Text = item.naam;
            mlblVoorraadAantal.Text = item.voorraad.ToString();
            itemvoorraad = item.voorraad;
            //Laad Voorraad voor menu item functie
        }

        private void MbtnAfbreken_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toevoegen afgebroken");
            this.Close();
        }

        private void NumAantal_ValueChanged(object sender, EventArgs e)
        {
            //

            int aantal = Convert.ToInt32(numAantal.Value);

            int voorraad = itemvoorraad - aantal;
            mlblVoorraadAantal.Text = voorraad.ToString();
        }
    }
}
