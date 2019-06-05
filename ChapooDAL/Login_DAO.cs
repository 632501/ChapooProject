using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooDAL
{
    public class Login_DAO : Base
    {
        public string conn = "Data Source=den1.mssql7.gear.host; Initial Catalog = chapoo1819sdb15; User=chapoo1819sdb15; Password=Uh6Q-7?9ykHi";
        protected SqlConnection con;


        public void AddUser(int werknemerID, string wachtWoord, string naam, string functie)
        {
            string query = "INSERT INTO Inlog(werknemer_ID, wachtwoord, naam, functie) values(" + werknemerID + ", '" + wachtWoord + "', '" + naam + "', '" + functie + "')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void RemoveUser(int wachtwoord)
        {
            string query = "DELETE FROM Inlog WHERE wachtwoord = " + wachtwoord + "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public bool Login(string wachtwoord)
        {
            bool correcteInlog;
            con = new SqlConnection(conn);

            string query = "SELECT wachtwoord FROM Inlog WHERE wachtwoord = '" + wachtwoord + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteSelectQuery(query, sqlParameters);


            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            //als de inlogdata overeenkomt met dat uit de database dan wordt de login panel gehide
            if (dt.Rows.Count == 1)
            {
                correcteInlog = true;
            }
            //als de data niet kloppen dan wordt er een message geshowt dat de data verkeerd is
            else
            {
                correcteInlog = false;
            }

            return correcteInlog;
        }

        public string Functie(string wachtwoord)
        {
            string functie = "";
            con = new SqlConnection(conn);
            string query = "Select wachtwoord, functie From Inlog Where wachtwoord = '" + wachtwoord + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            //ExecuteSelectQuery(query, sqlParameters);

            if (Login(wachtwoord) == true)
            {
                con.Open();

                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader dr = command.ExecuteReader();
                dr.Read();
                functie = dr["functie"].ToString();
            }
            return functie;
        }

        public string Naam(string wachtwoord)
        {
            string naam = "";
            con = new SqlConnection(conn);
            string query = "Select naam from Inlog where wachtwoord = '" + wachtwoord + "'";

            con.Open();

            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader dr = command.ExecuteReader();
            dr.Read();
            naam = (string)dr["naam"];

            return naam;
        }
    }
}
