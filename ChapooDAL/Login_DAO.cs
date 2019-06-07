﻿using System;
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

        public void RemoveUser(string wachtwoord)
        {
            string query = "DELETE FROM Inlog WHERE wachtwoord = " + wachtwoord + "";
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
                    werknemer_ID = (int)dr["werknemer_ID"],
                    naam = (String)(dr["naam"]),
                    wachtwoord = (string)dr["wachtwoord"],
                    functie = (String)(dr["functie"])

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
    }
}
