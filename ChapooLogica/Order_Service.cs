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
        public List<Bestelling> GetTodaysOrders()
        {
            List<Bestelling> orders = new List<Bestelling>();
            DataTable dataTable = order_DAO.Get_All_Orders();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bestelling order = new Bestelling()
                {
                    bestelling_ID = (int)dr["bestelling_ID"],
                    commentaar = (dr["commentaar"] == null) ? string.Empty : dr["commentaar"].ToString(),
                    datum = dr["datum"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["datum"]),
                    orderItems = GetOrderItems((int)dr["bestelling_ID"]),
                    tafel_ID = (int)dr["tafel_ID"]

                };
                orders.Add(order);
            }
    
            return orders;
        }
        public void FinishOrder(int orderId)
        {
            order_DAO.Finish_Order(orderId);

        }
        public List<OrderItem> GetOrderItems(int bestellingId)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            DataTable dataTable = order_DAO.Get_Order_Items(bestellingId);

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                    order_ID = (int)dr["order_ID"],
                    Aantal = (int)dr["aantal"],
                    Comment = (dr["commentaar"] == null) ? string.Empty : dr["commentaar"].ToString(),
                    menuItem = menu_Service.GetItem((int)dr["menu_ID"]),
                    Status = dr["status"].ToString(),
                    TafelNummer = (int)dr["tafelnummer"],
                    Werknemer = login_Service.GetEmployee((int)dr["werknemer_ID"])
                };
                orderItems.Add(orderItem);
            }
            return orderItems;
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
            List<OrderItem> orderItems = new List<OrderItem>();
            DataTable dataTable = order_DAO.Get_Order_Items_Per_Table(tafelnummer, bestellingId);

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                    order_ID = (int)dr["order_ID"],
                    Aantal = (int)dr["aantal"],
                    Comment = (dr["commentaar"] == null) ? string.Empty : dr["commentaar"].ToString(),
                    menuItem = menu_Service.GetItem((int)dr["menu_ID"]),
                    Status = dr["status"].ToString(),
                    TafelNummer = (int)dr["tafelnummer"],
                    Werknemer = login_Service.GetEmployee((int)dr["werknemer_ID"])
                };
                orderItems.Add(orderItem);
            }
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

        public void Paid(int tafel_ID, string amountWithBtw, string tip, string comment, int bestelling_ID, string paymentType)
        {
            string date = DateTime.Now.ToShortDateString();

            order_DAO.Paid(tafel_ID, date, amountWithBtw, tip, comment, bestelling_ID, paymentType);
        }

        public Bestelling Orders(int tafel_ID)
        {
            Bestelling orders = new Bestelling();
            orders = order_DAO.Orders(tafel_ID);

            return orders;
        }
    }
}
