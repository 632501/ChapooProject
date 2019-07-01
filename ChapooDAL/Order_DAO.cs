using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using ChapooModel;
using ChapooModel.Models;

namespace ChapooDAL
{
    public class Order_DAO : Base
    {
        public DataTable Get_All_Orders()
        {
            string query = string.Format("SELECT * FROM Bestelling");
            return ExecuteSelectQuery(query, new SqlParameter[0]);
        }

        public DataTable Get_Order_Items(int bestelling_ID)
        {
            string query = string.Format("SELECT * FROM OrderItem WHERE tafelnummer IS NOT null AND bestelling_ID = '{0}'", bestelling_ID);
            return ExecuteSelectQuery(query, new SqlParameter[0]);
        }

        public List<Bestelling> Get_Order_Per_Table(int tafelnummer)
        {
            string query = string.Format("SELECT * FROM Bestelling WHERE tafel_ID = '{0}' ", tafelnummer);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Bestelling> ReadOrders(DataTable dataTable)
        {
            
            List<Bestelling> bestellingen = new List<Bestelling>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bestelling bestelling = new Bestelling()
                {
                    bestelling_ID = (int)dr["bestelling_ID"],
                    commentaar = (String)(dr["commentaar"].ToString()),
                    datum = (DateTime)dr["datum"],
                    tafel_ID = (int)dr["tafel_ID"]

                };
                bestellingen.Add(bestelling);
            }
            return bestellingen;
        }

        public DataTable Get_Order_Items_Per_Table(int tafelnummer, int bestelling_ID)
        {
            string query = string.Format("SELECT * FROM OrderItem WHERE tafelnummer = '{0}' AND bestelling_ID = '{1}'",tafelnummer, bestelling_ID);
            return ExecuteSelectQuery(query, new SqlParameter[0]);
        }
        public void Finish_Order(int id)
        {
            string query = string.Format("UPDATE OrderItem SET status = 'Gereed' WHERE order_ID = '{0}'", id);
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        public void UnFinish_Order(int id)
        {
            string query = string.Format("UPDATE OrderItem SET status = 'Bezig' WHERE order_ID = '{0}'", id);
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        public void DeleteOrderItem(int orderItem)
        {
            string query = string.Format("DELETE FROM OrderItem WHERE order_ID = '{0}'",orderItem);
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        public void DeleteOrderItemByID(int bestellingID)
        {
            string query = string.Format("DELETE FROM OrderItem WHERE bestelling_ID = '{0}'", bestellingID);
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        // Bon gedeelte
        public void Paid(int tafel_ID, string date, string amountString, string tipString, string comment, int bestelling_ID, string paymentType)
        {
            string queryPaid = "UPDATE Bestelling SET betaald = 1 FROM Bestelling AS BE JOIN Tafel AS T ON T.tafel_ID = BE.tafel_ID WHERE T.tafel_ID = " + tafel_ID + " AND BE.betaald = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(queryPaid, sqlParameters);

            string queryBon = "SET IDENTITY_INSERT Bon OFF INSERT INTO Bon(datum, totaalprijs, fooi, commentaar, bestelling_ID, betaaltype) values(" + date + ", CONVERT(varchar, CAST('" + amountString + "' AS money)), CONVERT(varchar, CAST('" + tipString + "' AS money)), '" + comment + "', " + bestelling_ID + ", '" + paymentType + "')";
            ExecuteEditQuery(queryBon, sqlParameters);
        }

        public Bestelling Orders(int tafel_ID)
        {
            string query = "SELECT O.aantal, O.bestelling_ID, M.naam, M.prijs, M.btwPercentage FROM OrderItem AS O JOIN Menu AS M ON O.menu_ID = M.menu_ID JOIN Bestelling AS B ON O.bestelling_ID = B.bestelling_ID WHERE B.tafel_ID = " + tafel_ID + " AND B.betaald = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadBonOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        private Bestelling ReadBonOrders(DataTable dataTable)
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
            Orders.bestelling_ID = Orders.orderItems[0].bestelling_ID;

            return Orders;
        }
    }
}
