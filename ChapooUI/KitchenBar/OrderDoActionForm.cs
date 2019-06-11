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
using ChapooModel;
using ChapooLogica;
using ChapooModel.Models;

namespace ChapooUI
{
    public partial class OrderDoActionForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private readonly Order_Service order_Service = new Order_Service();
        private readonly KitchenActionForm mainWindow;

        private OrderItem orderItem;
        private bool isDone;

        public OrderDoActionForm(OrderItem orderItem, KitchenActionForm mainWindowUI, bool isDone)
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.orderItem = orderItem;
            mainWindow = mainWindowUI;
            this.isDone = isDone;

        }

        private void OrdersOverviewForm_Load(object sender, EventArgs e)
        {
            Text = "Actie voor order: " + orderItem.order_ID;
            orderInfo.Text = string.Format("Order: {0}\r\nTafel: {1}\r\nAantal: {2}\r\nBestelling: {3}\r\nCommentaar: {4}\r\nWerknemer: {5}"
                ,orderItem.order_ID, orderItem.TafelNummer, orderItem.Aantal, orderItem.menuItem.naam, orderItem.Comment, orderItem.Werknemer.naam);

            if (isDone)
                finishOrderButton.Text = "GEREED MELDEN";
            else
                finishOrderButton.Text = "ONGEREED MELDEN";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void finishOrderButton_Click(object sender, EventArgs e)
        {
            if(isDone)
                order_Service.FinishOrder(this.orderItem.order_ID);
            else
                order_Service.UnFinishOrder(this.orderItem.order_ID);
            mainWindow.UpdateData();
            this.Close();
        }
    }
}
