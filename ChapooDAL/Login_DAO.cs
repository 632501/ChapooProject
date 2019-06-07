using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ChapooModel;
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
            string query = "SET IDENTITY_INSERT Inlog ON INSERT INTO Inlog(werknemer_ID, wachtwoord, naam, functie) values(" + werknemerID + ", '" + wachtWoord + "', '" + naam + "', '" + functie + "') SET IDENTITY_INSERT Inlog OFF";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void RemoveUser(int wachtwoord)
        {
            string query = "DELETE FROM Inlog WHERE wachtwoord = " + wachtwoord + "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public bool Login(string password)
        {
            //bool correctLogin;
            //con = new SqlConnection(conn);

            //string query = "SELECT wachtwoord FROM Inlog WHERE wachtwoord = '" + password + "'";
            //SqlParameter[] sqlParameters = new SqlParameter[0];
            //ExecuteSelectQuery(query, sqlParameters);


            //SqlDataAdapter sda = new SqlDataAdapter(query, con);

            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            ////als de inlogdata overeenkomt met dat uit de database dan wordt de login panel gehide
            //if (dt.Rows.Count == 1)
            //{
            //    correctLogin = true;
            //}
            ////als de data niet kloppen dan wordt er een message geshowt dat de data verkeerd is
            //else
            //{
            //    correctLogin = false;
            //}

            //return correctLogin;

            bool correctLogin;
            con = new SqlConnection(conn);

            string query = "select wachtwoord from Inlog where wachtwoord = '" + password + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            //ExecuteSelectQuery(query, sqlParameters);

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                correctLogin = true;
            }
            else
            {
                correctLogin = false;
            }

            return correctLogin;

        }

        public List<Inlog> Employee(string password)
        {
            List<Inlog> Employees = new List<Inlog>();
            con = new SqlConnection(conn);
            string query = "Select * From Inlog Where wachtwoord = '" + password + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            //ExecuteSelectQuery(query, sqlParameters);

            if (Login(password) == true)
            {
                con.Open();
                Inlog employee = new Inlog();

                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader dr = command.ExecuteReader();
                dr.Read();
                employee.functie = dr["functie"].ToString();
                employee.naam = dr["naam"].ToString();
                employee.wachtwoord = dr["wachtwoord"].ToString();
                Employees.Add(employee);
            }
            return Employees;
        }

        public string Name(string password)
        {
            string name = "";
            con = new SqlConnection(conn);
            string query = "Select naam from Inlog where wachtwoord = '" + password + "'";

            con.Open();

            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader dr = command.ExecuteReader();
            dr.Read();
            name = (string)dr["naam"];

            return name;
        }
    }
}
