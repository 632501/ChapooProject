using ChapooDAL;
using ChapooModel;
using ChapooModel.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooLogica
{
    public class Order_Service
    {
        private Order_DAO order_DAO = new Order_DAO();
        private Menu_Service menu_Service = new Menu_Service();
        private Login_Service login_Service = new Login_Service();
        public List<BestellingOrderItem> GetAllKitchenOrders(bool showFinished)
        {
            List<BestellingOrderItem> orders = order_DAO.Get_All_Kitchen_Orders(showFinished);
            return orders;
        }
        public List<BestellingOrderItem> GetAllBarOrders(bool showFinished)
        {
            List<BestellingOrderItem> orders = order_DAO.Get_All_Bar_Orders(showFinished);
            return orders;
        }
        public void FinishOrder(int orderId)
        {
            order_DAO.Finish_Order(orderId);
        }
        

        public void UnFinishOrder(int orderId)
        {
            order_DAO.UnFinish_Order(orderId);
        }

        public List<Bestelling> GetTablesOrder(int tafelnummer)
        {
            List<Bestelling> orders = new List<Bestelling>();
            orders = order_DAO.Get_Order_Per_Table(tafelnummer);
            return orders;
        }

        public List<OrderItem> GetTablesOrderItems(int tafelnummer, int bestellingId)
        {
            List<OrderItem> orderItems = order_DAO.Get_Order_Items_Per_Table(tafelnummer, bestellingId);
           
            return orderItems;
        }

        public void DeleteOrder(int orderId)
        {
            order_DAO.DeleteOrderItem(orderId);
        }

        public void DeleteOrderItemsByID(int bestellingID)
        {
            order_DAO.DeleteOrderItemByID(bestellingID);
        }

        // bon gedeelte 

        public void Paid(int tafel_ID, string amountWithBtw, string tip, string comment, int bestelling_ID)
        {
            string date = DateTime.Now.ToShortDateString();

            order_DAO.Paid(tafel_ID, date, amountWithBtw, tip, comment, bestelling_ID);
        }

        public Bestelling Orders(int tafel_ID)
        {
            Bestelling orders = new Bestelling();
            orders = order_DAO.Orders(tafel_ID);

            return orders;
        }

        public void EditOrder(OrderItem o)
        {
            order_DAO.EditOrder(o);
        }
    }
}
