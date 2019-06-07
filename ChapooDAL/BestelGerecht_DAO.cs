using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooDAL
{
    public class BestelGerecht_DAO
    {

        public string conn = "Data Source=den1.mssql7.gear.host; Initial Catalog = chapoo1819sdb15; User=chapoo1819sdb15; Password=Uh6Q-7?9ykHi";
        protected SqlConnection con;

        public string OrderStatus(int tableNumber)
        {
            string status = " ";
            string query = "Select status from Bestel_Gerecht where tafelnummer = '" + tableNumber + "'";
            con = new SqlConnection(conn);

            con.Open();

            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader dr = command.ExecuteReader();
            dr.Read();
            status = (string)dr["status"];

            return status;
        }
    } 
}
