using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;

namespace ChapooDAL
{
    public class Tafel_DAO
    {
        public string conn = "Data Source=den1.mssql7.gear.host; Initial Catalog = chapoo1819sdb15; User=chapoo1819sdb15; Password=Uh6Q-7?9ykHi";
        protected SqlConnection con;

        public List<Tafel> Tafels()
        {
            con = new SqlConnection(conn);
            string query = "select * from Tafel";

            List<Tafel> tables = new List<Tafel>();

            Tafel table = new Tafel();

            //zorgen dat de query wordt uitgevoerd en de items aan de dingen worden gelinkt

            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader dr = command.ExecuteReader();
            dr.Read();
            table.tafelnummer = (int)dr["tafelnummer"];
            table.bezet = (bool)dr["naam"];
            tables.Add(table);

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
    }
}
