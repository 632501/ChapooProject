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
        public string conn = "Data Source=den1.mssql7.gear.host; Initial Catalog = dbchapoo20; User=dbchapoo20; Password=Ct5E_c83t7-J";
        protected SqlConnection con;


        public void AddUser(int werknemerID, string wachtWoord, string naam, string functie)
        {
            string query = "SET IDENTITY_INSERT Inlog ON INSERT INTO Inlog(wachtwoord, naam, functie, status) values(" + werknemerID + " '" + wachtWoord + "', '" + naam + "', '" + functie + "', 'werkend') SET IDENTITY_INSERT Inlog OFF";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void FireEmployee(int ID)
        {
            string query = "UPDATE Inlog SET [status] = 'inactief' WHERE werknemer_id = "+ID;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public bool Login(string password)
        {
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

        public Inlog GetEmployee(int ID)
        {
            string query = "Select * From Inlog Where werknemer_ID = '" +ID + "'";
            con = new SqlConnection(conn);
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader datareader = command.ExecuteReader();
            var dataTable = new DataTable();
            dataTable.Load(datareader);
            DataRow dr = dataTable.Rows[0];

            Inlog Employee = new Inlog()
            {
                werknemer_id = (int) dr["werknemer_id"],
                wachtwoord = (string) dr["wachtwoord"],
                naam = (string) dr["naam"],
                functie = (string) dr["functie"],
                status = (string) dr["status"]
            };

            return Employee;
        }
        public Inlog GetEmployeeWithPassword(string password)
        {
            Inlog Employee;
            string query = "Select * From Inlog Where wachtwoord = '" + password + "'";
            con = new SqlConnection(conn);
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader datareader = command.ExecuteReader();
            var dataTable = new DataTable();
            dataTable.Load(datareader);
            if (dataTable.Rows.Count > 0)
            {
                DataRow dr = dataTable.Rows[0];
                Employee = new Inlog()
                {
                    werknemer_id = (int)dr["werknemer_id"],
                    wachtwoord = (string)dr["wachtwoord"],
                    naam = (string)dr["naam"],
                    functie = (string)dr["functie"],
                    status = (string)dr["status"]
                };

                return Employee;
            }
            else {
            return null;
            }



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

        public string Function(string password)
        {
            string function = " ";
            con = new SqlConnection(conn);
            string query = "Select functie from Inlog where wachtwoord = '" + password + "'";

            con.Open();

            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            function = (string)reader["functie"];

            return function;
        }


        public List<Inlog> GetEmployeeList()
        {
            string query = "SELECT * FROM Inlog";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Inlog> ReadTables(DataTable dataTable)
        {
            List<Inlog> EmployeeList = new List<Inlog>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Inlog Employee = new Inlog()
                {
                    werknemer_id = (int)dr["werknemer_ID"],
                    naam = (String)(dr["naam"]),
                    wachtwoord = (string)dr["wachtwoord"],
                    functie = (String)(dr["functie"]),
                    status = (string)(dr["status"])

                };
                EmployeeList.Add(Employee);
            }
            return EmployeeList;
        }

        public void ChangeUser(int ID, string name, string password, string function)
        {
            string query = "UPDATE Inlog SET naam = '" + name + "', wachtwoord = '" + password + "', functie = '" + function + "' WHERE werknemer_ID = " + ID;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void AlterStatusEmployee(int ID)
        {
            string query = "UPDATE Inlog SET [status] = 'werkend' WHERE werknemer_ID = " + ID;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }



    }
}
