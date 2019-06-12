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

        public Decimal TotalAmount(int tafel_ID)
        {
            Decimal totalAmount = bon_db.TotalAmount(tafel_ID);

            return totalAmount;
        }

        public void Paid(int tafel_ID, double tip, string paymentType, string comment)
        {
            bon_db.Paid(tafel_ID, tip, paymentType, comment);
        }

        public Bestelling Orders(int tafel_ID)
        {
            Bestelling orders = new Bestelling();
            orders = bon_db.Orders(tafel_ID);

            //Bestelling returnlist = new Bestelling();
            //int count = 1;

            //foreach (OrderItem x in orders.orderItems)
            //{
            //    if (count == 1)
            //    {
            //        returnlist.orderItems.Add(x);
            //    }
            //    else
            //    {
            //        foreach (OrderItem y in returnlist.orderItems)
            //        {
            //            if (y.menuItem.naam == x.menuItem.naam)
            //            {
            //                y.Aantal += x.Aantal;
            //                orders.orderItems.Remove(x);
            //            }
            //            else
            //            {
            //                returnlist.orderItems.Add(x);
            //            }

            //            if (count == 1)
            //            {
            //                returnlist.orderItems.Remove(y);
            //                count = 2;
            //            }
            //        }
            //    }
            //}

            return orders;
        }
    }
}
