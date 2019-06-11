﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ChapooModel;
using System.Text;
using System.Threading.Tasks;
using ChapooModel.Models;

namespace ChapooDAL
{
    public class Bon_DAO : Base
    {

        public int TotalAmount(int tafel_ID)
        {
            string query = "SELECT B.totaalprijs FROM Bon AS B JOIN Bestelling AS BE ON B.bestel_ID = BE.bestelling_ID JOIN Tafel AS T ON T.tafel_ID = BE.tafel_ID WHERE T.tafel_ID = " + tafel_ID + " AND BE.betaald = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTotalAmount(ExecuteSelectQuery(query, sqlParameters));
        }

        private int ReadTotalAmount(DataTable dataTable)
        {
            int tp = 0;

            foreach (DataRow dr in dataTable.Rows)
            {
                Bon bon = new Bon
                {
                    totaalprijs = (int)dr["totaalprijs"]
                };
                tp = bon.totaalprijs;
            }
            return tp;
        }

        public void Paid(int tafel_ID, double tip, string paymentType, string comment)
        {
            string queryPaid = "UPDATE Bestelling SET betaald = 1 FROM Bestelling AS BE JOIN Tafel AS T ON T.tafel_ID = BE.tafel_ID WHERE T.tafel_ID = " + tafel_ID + " AND BE.betaald = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(queryPaid, sqlParameters);

            string queryTip = "UPDATE Bon SET fooi = " + tip + " FROM Bon AS B JOIN Bestelling AS BE ON B.bestel_ID = BE.bestelling_ID JOIN Tafel AS T ON T.tafel_ID = BE.tafel_ID WHERE T.tafel_ID = " + tafel_ID + " AND BE.betaald = 0";
            
            ExecuteEditQuery(queryTip, sqlParameters);

            string queryPaymentType = "UPDATE Bon SET betaaltype = '" + paymentType + "' FROM Bon AS B JOIN Bestelling AS BE ON B.bestel_ID = BE.bestelling_ID JOIN Tafel AS T ON T.tafel_ID = BE.tafel_ID WHERE T.tafel_ID = " + tafel_ID + " AND BE.betaald = 0";

            ExecuteEditQuery(queryPaymentType, sqlParameters);

            string queryComment = "UPDATE Bon SET commentaar = '" + comment + "' FROM Bon AS B JOIN Bestelling AS BE ON B.bestel_ID = BE.bestelling_ID JOIN Tafel AS T ON T.tafel_ID = BE.tafel_ID WHERE T.tafel_ID = " + tafel_ID + " AND BE.betaald = 0";
            ExecuteEditQuery(queryComment, sqlParameters);
        }

        public Bestelling Orders(int tafel_ID)
        {
            string query = "SELECT O.aantal, M.naam, M.prijs, M.btwPercentage FROM OrderItem AS O JOIN Menu AS M ON O.menu_ID = M.menu_ID JOIN Bestelling AS B ON O.bestelling_ID = B.bestelling_ID WHERE B.tafel_ID = " + tafel_ID;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        private Bestelling ReadOrders(DataTable dataTable)
        {
            Bestelling Orders = new Bestelling();
            Orders.orderItems = new List<OrderItem>();
            MenuItem m = new MenuItem();
            
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem oI = new OrderItem()
                {
                    Aantal = (int)dr["aantal"],
                };
                m.prijs = (int)dr["prijs"];
                m.naam = (string)dr["naam"];
                m.btwPercentage = (int)dr["btwPercentage"];

                oI.menuItem = m;

                Orders.orderItems.Add(oI);
            }
            return Orders;
        }
    }
}
