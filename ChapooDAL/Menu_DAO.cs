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
        public List<Menu> Db_Get_All_Menus()
        {
            string query = "SELECT Menu_Id, Naam FROM [Menu]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Menu> ReadTables(DataTable dataTable)
        {
            List<Menu> menus = new List<Menu>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Menu menu = new Menu()
                {
                    menu_ID = (int)dr["menu_Id"],
                    naam = (String)(dr["naam"].ToString()),
                    prijs = (int)dr["prijs"],
                    categorie = (String)(dr["categorie"].ToString())

                };
                menus.Add(menu);
            }
            return menus;
        }

        public List<Menu> GetAllLunch()
        {
            string query = "SELECT Menu_Id, Naam, Prijs, Categorie FROM [Menu] where Categorie = 'Lunch'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Menu> GetAllDiner()
        {
            string query = "SELECT Menu_Id, Naam, Prijs, Categorie FROM [Menu] where Categorie = 'Diner'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Menu> GetAllDrinks()
        {
            string query = "SELECT menu_ID, naam, prijs, categorie FROM [Menu] ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}
