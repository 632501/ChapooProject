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
            string query = string.Format("SELECT * FROM Bestel_Gerecht WHERE tafelnummer IS NOT null AND bestelling_ID = '{0}'", bestelling_ID);
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
            string query = string.Format("SELECT * FROM Bestel_Gerecht WHERE tafelnummer = '{0}' AND bestelling_ID = '{1}'", tafelnummer, bestelling_ID);
            return ExecuteSelectQuery(query, new SqlParameter[0]);
        }
        public void Finish_Order(int id)
        {
            string query = string.Format("UPDATE Bestel_Gerecht SET status = 'Gereed' WHERE order_ID = '{0}'", id);
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        public void UnFinish_Order(int id)
        {
            string query = string.Format("UPDATE Bestel_Gerecht SET status = 'Bezig' WHERE order_ID = '{0}'", id);
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        public void DeleteOrderItem(int orderItem)
        {
            string query = string.Format("DELETE FROM Bestel_Gerecht WHERE order_ID = '{0}'", orderItem);
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        public void DeleteOrderItemByID(int bestellingID)
        {
            string query = string.Format("DELETE FROM Bestel_Gerecht WHERE bestelling_ID = '{0}'", bestellingID);
            ExecuteEditQuery(query, new SqlParameter[0]);
        }
    }
}
