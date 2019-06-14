using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel.Models;

namespace ChapooLogica
{
    public class Bestelling_Service
    {
        private Bestelling_DAO bestelling_db = new Bestelling_DAO();

        public void AddOrder(Bestelling bestelling)
        {
            bestelling_db.AddOrder(bestelling);
        }

        public Bestelling GetLatestOrder()
        {
            Bestelling bestelling = new Bestelling();
            bestelling = bestelling_db.GetLatestOrder();
            return bestelling;
        }

        public void AddOrderItem(OrderItem o)
        {
            bestelling_db.AddOrderItem(o);
        }

        public void DeleteOrders(int bestellingID)
        {
            bestelling_db.DeleteOrder(bestellingID);
        }
    }
}
