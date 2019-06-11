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
        private Order_DAO bestelling_DB = new Order_DAO();
        private Menu_Service menu_Service = new Menu_Service();
        private Login_Service login_Service = new Login_Service();
        public List<Bestelling> GetTodaysOrders()
        {
            List<Bestelling> orders = new List<Bestelling>();
            DataTable dataTable = bestelling_DB.Get_All_Orders();

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
            bestelling_DB.Finish_Order(orderId);

        }
        public List<OrderItem> GetOrderItems(int bestellingId)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            DataTable dataTable = bestelling_DB.Get_Order_Items(bestellingId);

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
            bestelling_DB.UnFinish_Order(orderId);
        }
    }
}
