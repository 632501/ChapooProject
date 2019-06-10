using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
