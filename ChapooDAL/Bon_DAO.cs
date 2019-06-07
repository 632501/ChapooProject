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

        public int TotalAmount(int tafel_ID)
        {
            string query = "SELECT B.totaalprijs FROM Bon AS B JOIN Bestelling AS BE ON B.bestel_ID = BE.bestelling_ID JOIN Tafel AS T ON T.tafel_ID = BE.tafel_ID WHERE T.tafel_ID = " + tafel_ID;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTotalAmount(ExecuteSelectQuery(query, sqlParameters));
        }

        private int ReadTotalAmount(DataTable dataTable)
        {
            int totaalbedrag = 0;

            foreach (DataRow dr in dataTable.Rows)
            {
                totaalbedrag = (int)dr["totaalprijs"];
            }
            return totaalbedrag;
        }

        public void Paid(int tafel_ID, double tip, string paymentType, string comment)
        {
            string queryPaid = "UPDATE Bestelling SET betaald = 'Afgerond' FROM Bestelling AS B JOIN Tafel AS T ON T.tafel_ID = B.tafel_ID WHERE T.tafel_ID = " + tafel_ID;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(queryPaid, sqlParameters);

            string queryTip = "UPDATE Bon SET fooi = " + tip + " FROM Bestelling AS B JOIN Tafel AS T ON T.tafel_ID = B.tafel_ID WHERE T.tafel_ID = " + tafel_ID;
            ExecuteEditQuery(queryTip, sqlParameters);

            string queryPaymentType = "UPDATE Bon SET fooi = '" + paymentType + "' FROM Bestelling AS B JOIN Tafel AS T ON T.tafel_ID = B.tafel_ID WHERE T.tafel_ID = " + tafel_ID;
            ExecuteEditQuery(queryPaymentType, sqlParameters);

            string queryComment = "UPDATE Bon SET commentaar = '" + comment + "' FROM Bestelling AS B JOIN Tafel AS T ON T.tafel_ID = B.tafel_ID WHERE T.tafel_ID = " + tafel_ID;
            ExecuteEditQuery(queryComment, sqlParameters);
        }

        public List<OrderItem> Order(int tafel_ID)
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrder(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderItem> ReadOrder(DataTable dataTable)
        {
            List<OrderItem> Orders = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem O = new OrderItem()
                {
                    Menu_ID = (int)(dr["menu_ID"]),
                    Aantal = (int)dr["aantal"]
                };
                Orders.Add(O);
            }
            return Orders;
        }
        //SELECT O.aantal, M.naam, M.prijs
        //FROM OrderItem AS O JOIN Menu AS M ON O.menu_ID = M.menu_ID

                    //JOIN Bestelling AS B ON O.bestelling_ID = B.bestelling_ID
        //WHERE B.tafel_ID = 4
    }
}
