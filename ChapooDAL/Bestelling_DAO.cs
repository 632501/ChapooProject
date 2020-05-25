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
    public class Bestelling_DAO :Base
    {
        public void AddOrder(Bestelling bestelling)
        {
            int i;
            if (bestelling.betaald)
            {
                i = 1;
            }
            else
            {
                i = 0;
            }
            DateTime varDate = DateTime.Now;
            string format = "MM-dd-yyyy HH:mm:ss";
            string query = "SET IDENTITY_INSERT Bestelling OFF INSERT INTO Bestelling (tafel_id, betaald, datum, commentaar) VALUES ('" + bestelling.tafel_id + "', '" + i + "', '"+ varDate.ToString(format)+ "', '"+bestelling.commentaar+"')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void AddOrderItem(OrderItem o)
        {
            string query = "SET IDENTITY_INSERT Bestel_Gerecht OFF INSERT INTO Bestel_Gerecht (bestelling_id,  werknemer_id, status, commentaar, aantal, gerecht_id, tafel_id) VALUES ('"+ o.bestelling_id + "', '" + o.Werknemer.werknemer_id + "', '" + o.Status + "', '" + o.Comment + "', '"+o.Aantal+"', '"+o.menuItem.menu_id+"', '"+o.tafel_id+ "')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public Bestelling GetLatestOrder()
        {
            string query = "SELECT * FROM Bestelling WHERE bestelling_id = (SELECT MAX(bestelling_id) FROM Bestelling)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            DataRow dr = dataTable.Rows[0];

            Bestelling bestelling = new Bestelling()
            {
                bestelling_id = (int)dr["bestelling_id"],
                tafel_id = (int)dr["tafel_id"],
                betaald = (bool)dr["betaald"],
                datum = (DateTime)dr["datum"]
            };

            return bestelling;
        }

        public void DeleteOrder(int bestellingID)
        {
                string query = string.Format("DELETE FROM Bestelling WHERE bestelling_id = '{0}'", bestellingID);
                ExecuteEditQuery(query, new SqlParameter[0]);
        }
    }
}
