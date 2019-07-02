using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;

namespace ChapooDAL
{
    public class Tafel_DAO : Base
    {
        public string conn = "Data Source=den1.mssql7.gear.host; Initial Catalog = chapoo1819sdb15; User=chapoo1819sdb15; Password=Uh6Q-7?9ykHi";
        protected SqlConnection con;

        public List<Tafel> Db_Get_All_Tables()
        {
            string query = "SELECT bezet, tafelnummer FROM [Tafel]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadAllTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Tafel> ReadAllTables(DataTable dataTable)
        {
            List<Tafel> tables = new List<Tafel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Tafel table = new Tafel()
                {
                    bezet = (bool)dr["bezet"],
                    tafelnummer = (int)dr["tafelnummer"]
                };
                tables.Add(table);
            }
            return tables;
        }


        public bool Occupied(int tableNumber)
        {
            bool occupied;
            con = new SqlConnection(conn);
            string query = "select bezet from Tafel where tafelnummer = '" + tableNumber + "'";

            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader dr = command.ExecuteReader();
            dr.Read();

            occupied = (bool)dr["bezet"];

            return occupied;
        }

        public void EditStatus(int tableNumber, bool status)
        {

            int state = 1;
            if(status == true)
            {
                state = 1;
            }

            string query = "UPDATE Tafel Set bezet = " + state + " where tafelnummer = " + tableNumber;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
