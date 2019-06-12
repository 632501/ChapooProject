using System;
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
        public void Paid(int tafel_ID, DateTime date, decimal totalPayment, decimal tip, string comment, int bestelling_ID, string paymentType)
        {
            string queryPaid = "UPDATE Bestelling SET betaald = 1 FROM Bestelling AS BE JOIN Tafel AS T ON T.tafel_ID = BE.tafel_ID WHERE T.tafel_ID = " + tafel_ID + " AND BE.betaald = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(queryPaid, sqlParameters);

            string nepdate = "NULL";

            // fix de juiste datum erin
            string queryBon = "SET IDENTITY_INSERT Bon OFF INSERT INTO Bon(datum, totaalprijs, fooi, commentaar, bestelling_ID, betaaltype) values(" + nepdate + ", " + totalPayment + ", " + tip + ", '" + comment + "', " + bestelling_ID + ", '" + paymentType + "')";
            ExecuteEditQuery(queryBon, sqlParameters);
        }

        public Bestelling Orders(int tafel_ID)
        {
            string query = "SELECT O.aantal, O.bestelling_ID, M.naam, M.prijs, M.btwPercentage FROM OrderItem AS O JOIN Menu AS M ON O.menu_ID = M.menu_ID JOIN Bestelling AS B ON O.bestelling_ID = B.bestelling_ID WHERE B.tafel_ID = " + tafel_ID + " AND B.betaald = 0";
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
                    bestelling_ID = (int)dr["bestelling_ID"]
                };
                m.prijs = (decimal)dr["prijs"];
                m.naam = (string)dr["naam"];
                m.btwPercentage = (int)dr["btwPercentage"];

                oI.menuItem = m;

                Orders.orderItems.Add(oI);
            }
            return Orders;
        }
    }
}
