using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogica
{
    public class Bon_Service
    {
        Bon_DAO bon_db = new Bon_DAO();

        public int Totaalbedrag(int tafel_ID)
        {
            int totalAmount = bon_db.TotalAmount(tafel_ID);

            return totalAmount;
        }

        public void Bestelling(int tafel_ID)
        {
            bon_db.Order(tafel_ID);
        }

        public void Betaald(int tafel_ID, double tip, string paymentType, string comment)
        {
            bon_db.Paid(tafel_ID, tip, paymentType, comment);
        }
    }
}
