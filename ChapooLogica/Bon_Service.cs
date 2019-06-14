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

        int Bestelling_ID;

        public void Paid(int tafel_ID, string amountWithBtw, string tip, string comment, string paymentType)
        {
            string date = DateTime.Now.ToShortDateString();

            bon_db.Paid(tafel_ID, date, amountWithBtw, tip, comment, Bestelling_ID, paymentType);
        }

        public Bestelling Orders(int tafel_ID)
        {
            Bestelling orders = new Bestelling();
            orders = bon_db.Orders(tafel_ID);

            this.Bestelling_ID = orders.orderItems[0].bestelling_ID;
            
            return orders;
        }
    }
}
