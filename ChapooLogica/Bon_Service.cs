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

            

            bon_db.Paid(tafel_ID, date, amountWithBtw, tip, comment, Bestelling_ID, paymentType);
        }

        public Bestelling Orders(int tafel_ID)
        {
            Bestelling orders = new Bestelling();
            orders = bon_db.Orders(tafel_ID);

            this.Bestelling_ID = orders.bestelling_ID;

            Bestelling returnlist = new Bestelling();
            int count = 0;
            int newItem = 0;

            foreach (OrderItem x in orders.orderItems)
            {
                if (count == 0)
                {
                    returnlist.orderItems.Add(x);
                    count++;
                }

                foreach (OrderItem y in returnlist.orderItems)
                {
                    if (y.menuItem.naam == x.menuItem.naam)
                    {
                        y.Aantal += x.Aantal;
                    }
                    else
                    {
                        newItem++;
                    }

                    if (newItem == returnlist.orderItems.Count)
                    {
                        returnlist.orderItems.Add(x);
                    }
                }

                newItem = 0;
            }

            return returnlist;
        }
    }
}
