using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ChapooDAL;
using ChapooModel;
using ChapooModel.Models;

namespace ChapooLogica
{
    public class Bon_Service
    {
        Bon_DAO bon_db = new Bon_DAO();

        public int TotalAmount(int tafel_ID)
        {
            int totalAmount = bon_db.TotalAmount(tafel_ID);

            return totalAmount;
        }

        public void Paid(int tafel_ID, double tip, string paymentType, string comment)
        {
            bon_db.Paid(tafel_ID, tip, paymentType, comment);
        }

        public Bestelling Orders(int tafel_ID)
        {
            Bestelling bestelling = new Bestelling();
            Dictionary<string, int> bestelijst = new Dictionary<string, int>();
            int value = 0;
            int totaalprijs = 0;

            foreach(OrderItem o in bestelling.orderItems)
            {
                if (bestelijst.Keys.Contains(o.menuItem.naam))
                {
                   // bestelijst.Values[bestelijst.Keys.
                }
                else
                {
                    bestelijst.Add(o.menuItem.naam, o.Aantal);
                }
            }

            bestelling = bon_db.Orders(tafel_ID);

            return bestelling;
        }
    }
}
