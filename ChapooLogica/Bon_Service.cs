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

        public void Paid(int tafel_ID, string amountWithBtw, string tip, string comment, int bestelling_ID, string paymentType)
        {
            string date = DateTime.Now.ToShortDateString();

            bon_db.Paid(tafel_ID, date, amountWithBtw, tip, comment, bestelling_ID, paymentType);
        }

        public Bestelling Orders(int tafel_ID)
        {
            Bestelling orders = new Bestelling();
            orders = bon_db.Orders(tafel_ID);

            return orders;
        }
    }
}
