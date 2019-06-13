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

        public void Paid(int tafel_ID, decimal amountWithBtw, decimal tip, string comment, string paymentType)
        {
            DateTime date = DateTime.Now;
            string amountString = amountWithBtw.ToString();
            string tipString = tip.ToString();

            amountString.Replace(',', '.');
            tipString.Replace(',', '.');

            bon_db.Paid(tafel_ID, date, amountString, tipString, comment, Bestelling_ID, paymentType);
        }

        public Bestelling Orders(int tafel_ID)
        {
            Bestelling orders = new Bestelling();
            orders = bon_db.Orders(tafel_ID);
            //Bestelling compareList = new Bestelling();

            this.Bestelling_ID = orders.bestelling_ID;
            
            //int count1 = 0;
            //int count2 = 0;

            //foreach (OrderItem x in orders.orderItems)
            //{
            //    count1++;
            //    count2 = count1;

            //    foreach (OrderItem y in compareList.orderItems)
            //    {
            //        if (count1 != count2 && y.menuItem.naam == x.menuItem.naam)
            //        {
            //            x.Aantal += y.Aantal;

            //            orders.orderItems.Remove(y);
            //            compareList.orderItems.Remove(y);
            //        }

            //        count2++;
            //    }
            //}

            return orders;
        }
    }
}
