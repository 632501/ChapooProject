using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooLogica
{
    public class Login_Service
    {
        Login_DAO inlog_db = new Login_DAO();
        List<Inlog> employeeList;

        public List<Inlog> GetEmployeeList()
        {
            employeeList = new List<Inlog>();
            List<Inlog> aangepasteLijst = new List<Inlog>();

            aangepasteLijst = inlog_db.GetEmployeeList();
            employeeList = inlog_db.GetEmployeeList();

            for(int i = aangepasteLijst.Count - 1; i >= 0; i--)
            {
                if(aangepasteLijst[i].status == "inactief")
                {
                    aangepasteLijst.Remove(aangepasteLijst[i]);
                }
            }
            return aangepasteLijst;
        }
        public Inlog GetEmployee(int id)
        {
            return inlog_db.GetEmployee(id);
        }
        public void AddEmployee(int ID, string name, string password, string function)
        {
            
            inlog_db.AddUser(ID, password, name, function); 
        }

        public void ChangeEmployee(int ID, string name, string password, string function)
        {
            inlog_db.ChangeUser(ID, name, password, function);
        }

        public void FireEmployee(int ID)
        {
            inlog_db.FireEmployee(ID);
        }

        public bool Login(string password)
        {
            return inlog_db.Login(password);
        }

        public Inlog GetEmployeeWithPassword(string password)
        {
            return inlog_db.GetEmployeeWithPassword(password);
        }
    }
}
