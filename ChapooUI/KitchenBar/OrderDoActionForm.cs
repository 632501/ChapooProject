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

        // Order service object
        private readonly Order_Service order_Service = new Order_Service();
        
        // Our main window that send us here.
        private readonly KitchenActionForm mainWindow;

        // Order item that we will work with.
        private BestellingOrderItem orderItem;

        // If the order is finished
        private bool isDone;

        public OrderDoActionForm(BestellingOrderItem orderItem, KitchenActionForm mainWindowUI, bool isDone)
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
            // Visual changes based on our data.
            Text = "Actie voor order: " + orderItem.OrderID;
            orderInfo.Text = string.Format("Order: {0}\r\nTafel: {1}\r\nAantal: {2}\r\nBestelling: {3}\r\nCommentaar: {4}\r\nWerknemer: {5}"
                ,orderItem.OrderID, orderItem.TafelNummer, orderItem.Aantal, orderItem.MenuItemNaam, orderItem.OrderCommentaar, orderItem.WerknemerNaam);

            if (isDone)
                finishOrderButton.Text = "GEREED MELDEN";
            else
                finishOrderButton.Text = "ONGEREED MELDEN";

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Close this form
            this.Close();
        }

        private void finishOrderButton_Click(object sender, EventArgs e)
        {
            // Finish or unfinish order based on what it currently is.
            if(isDone)
                order_Service.FinishOrder(this.orderItem.OrderID);
            else
                order_Service.UnFinishOrder(this.orderItem.OrderID);

            // Update our data on our main window so the user sees the changes.
            mainWindow.UpdateData();

            // Close this form.
            this.Close();
        }
    }
}
