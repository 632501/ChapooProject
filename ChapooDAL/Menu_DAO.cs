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
            string query = "SELECT Menu_Id, Naam FROM [Menu]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menus = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menu = new MenuItem()
                {
                    menu_ID = (int)dr["menu_Id"],
                    naam = (String)(dr["naam"].ToString()),
                    prijs = (int)dr["prijs"],
                    categorie = (String)(dr["categorie"].ToString()),
                    voorraad = (int)dr["vorraad"]

                };
                menus.Add(menu);
            }
            return menus;
        }

        public List<MenuItem> GetAllLunch()
        {
            string query = "SELECT menu_Id, naam, prijs, categorie, vorraad FROM [Menu]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<MenuItem> GetAllDiner()
        {
            string query = "SELECT menu_Id, naam, prijs, categorie, vorraad FROM [Menu]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<MenuItem> GetAllDrinks()
        {
            string query = "SELECT menu_ID, naam, prijs, categorie, vorraad FROM [Menu] ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}
