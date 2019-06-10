using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using ChapooModel;

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
            string query = "SET IDENTITY_INSERT Bestelling OFF INSERT INTO Bestelling (tafel_ID, betaald) VALUES (" + bestelling.tafel_ID + ", " + i + ")";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public Bestelling GetLatestOrder()
        {
            string query = "SELECT * FROM Bestelling WHERE bestelling_ID = (SELECT MAX(bestelling_ID) FROM Bestelling)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            DataRow dr = dataTable.Rows[0];

            Bestelling bestelling = new Bestelling()
            {
                bestelling_ID = (int)dr["bestelling_ID"],
                tafel_ID = (int)dr["tafel_ID"],
                betaald = (bool)dr["betaald"]
            };

            return bestelling;
        }
    }
}
