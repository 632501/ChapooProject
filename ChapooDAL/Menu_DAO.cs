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
    public class Menu_DAO : Base
    {
        public List<MenuItem> Db_Get_All_Menus()
        {
            string query = "SELECT * FROM [Menu]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menu = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    menu_id = (int)dr["menu_id"],
                    naam = (String)(dr["naam"].ToString()),
                    prijs = (Decimal)dr["prijs"],
                    categorie = (String)(dr["categorie"].ToString()),
                    voorraad = (int)dr["voorraad"]

                };
                menu.Add(menuItem);
            }
            return menu;
        }

        public List<MenuItem> GetAllLunch()
        {
            string query = "SELECT menu_id, naam, prijs, categorie, voorraad FROM [Menu] where categorie = 'lunch' AND voorraad > 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<MenuItem> GetAllDiner()
        {
            string query = "SELECT menu_id, naam, prijs, categorie, voorraad FROM [Menu] where categorie = 'diner' AND voorraad > 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<MenuItem> GetAllDrinks()
        {
            string query = "SELECT menu_id, naam, prijs, categorie, voorraad FROM Menu where categorie = 'dranken' AND voorraad > 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void ChangeSupply(string name, int amount)
        {
            string query = "Update Menu set voorraad = " + amount + " where naam = '" + name + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void ChangeMenu(int ID, string naam, string prijs, string categorie)
        {
            string query = "UPDATE Menu SET naam = '" + naam + "', prijs = CONVERT(VARCHAR, CAST('" + prijs + "' AS MONEY)), categorie = '" + categorie + "' WHERE menu_ID = " + ID;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void AddMenuItem(int ID, string naam, string prijs, string categorie, int voorraad, int btw)
        {
            string query = "set identity_insert  Menu  ON insert into Menu (menu_id, naam, prijs, categorie, voorraad, btwPercentage) values(" + ID + ", '" + naam + "', " + prijs + ", '" + categorie + "', " + voorraad + ", "+btw+") set identity_insert  Menu  OFF";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void RemoveItem(int ID)
        {
            string query = "DELETE FROM Menu WHERE menu_id = " + ID + "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public MenuItem GetSingleItem(string naam)
        {
            string query = "SELECT * FROM Menu WHERE naam = '" + naam+ "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            DataRow dr = dataTable.Rows[0];

            MenuItem item = new MenuItem()
            {
                menu_id = (int)dr["menu_id"],
                prijs = (Decimal)dr["prijs"],
                naam = (string)dr["naam"],
                btwPercentage = (int)dr["btwpercentage"],
                categorie = (string)dr["categorie"],
                voorraad = (int)dr["voorraad"]
            };

            return item;
        }
        public MenuItem GetSingleItem(int id)
        {
            string query = "SELECT * FROM Menu WHERE menu_id = '" + id + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            DataRow dr = dataTable.Rows[0];

            MenuItem item = new MenuItem()
            {
                menu_id = (int)dr["menu_id"],
                prijs = (Decimal)dr["prijs"],
                naam = (string)dr["naam"],
                btwPercentage = (int)dr["btwpercentage"],
                categorie = (string)dr["categorie"],
                voorraad = (int)dr["voorraad"]
            };

            return item;
        }
    }
}
