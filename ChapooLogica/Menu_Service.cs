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

        public List<MenuItem> GetMenu()
        {
            List<MenuItem> menu = new List<MenuItem>();
            menu = menu_db.Db_Get_All_Menus();
            return menu;
        }

        public List<MenuItem> GetDrinks()
        {
            Menu_DAO DrinkDAO = new Menu_DAO();
            List<MenuItem> drinks = DrinkDAO.GetAllDrinks();
            return drinks;
        }

        public List<MenuItem> GetLunch()
        {
            Menu_DAO LunchDAO = new Menu_DAO();
            List<MenuItem> lunches = LunchDAO.GetAllLunch();
            return lunches;
        }

        public List<MenuItem> GetDiner()
        {
            Menu_DAO dinerDAO = new Menu_DAO();
            List<MenuItem> diners = dinerDAO.GetAllDiner();
            return diners;
        }
        public void ChangeSupply(string name, int amount)
        {
            menu_db.ChangeSupply(name, amount);
        }
        
        public void ChangeMenu(int ID, string naam, int prijs, string categorie)
        {
            menu_db.ChangeMenu(ID, naam, prijs, categorie);
        }

        public void AddMenuItem(int ID, string naam, int prijs, string categorie, int voorraad)
        {
            menu_db.AddMenuItem(ID, naam, prijs, categorie, voorraad);
        }

        public void RemoveItem(int ID)
        {
            menu_db.RemoveItem(ID);
        }
    }
}
