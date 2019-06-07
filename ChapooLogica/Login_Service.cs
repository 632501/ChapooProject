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


        public List<Inlog> GetEmployeeList()
        {
            List<Inlog> employeeList = new List<Inlog>();

            employeeList = inlog_db.GetEmployeeList();

            return employeeList;
        }

        public void AddEmployee(int ID, string name, string password, string function)
        {
            inlog_db.AddUser(ID, password, name, function); 
        }

        public void ChangeEmployee(int ID, string name, string password, string function)
        {
            inlog_db.ChangeUser(ID, password, name, function);
        }

        public void RemoveUser(string password)
        {
            inlog_db.RemoveUser(password);
        }
    }
}
