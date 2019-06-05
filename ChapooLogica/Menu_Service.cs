using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogica
{
    public class Menu_Service
    {
        Menu_DAO menu_db = new Menu_DAO();

        public List<Menu> GetMenus()
        {
            try
            {
                List<Menu> menu = menu_db.Db_Get_All_Menus();
                return menu;
            }
            catch (Exception exp)
            {
                //throw new Exception("Couldn't connect to database : " + exp.Message);

                //something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!*/
                List<Menu> menus = new List<Menu>();
                Menu a = new Menu();
                a.menu_ID = 201;
                menus.Add(a);
                return menus;

                //throw new Exception("Chapoop couldn't connect to the database");

            }
        }

        public List<Menu> GetDrinks()
        {
            Menu_DAO DrinkDAO = new Menu_DAO();
            List<Menu> drinks = DrinkDAO.GetAllDrinks();
            return drinks;
        }

        public List<Menu> GetLunch()
        {
            Menu_DAO LunchDAO = new Menu_DAO();
            List<Menu> lunches = LunchDAO.GetAllLunch();
            return lunches;
        }

        public List<Menu> GetDiner()
        {
            Menu_DAO dinerDAO = new Menu_DAO();
            List<Menu> diners = dinerDAO.GetAllDiner();
            return diners;
        }
    }
}
