using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using ChapooModel;
using ChapooModel.Models;

namespace ChapooDAL
{
    public class Order_DAO : Base
    {
        public DataTable Get_All_Orders()
        {
            string query = string.Format("SELECT * FROM Bestelling");
            return ExecuteSelectQuery(query, new SqlParameter[0]);
        }

        public DataTable Get_Order_Items(int bestelling_ID)
        {
            string query = string.Format("SELECT * FROM OrderItem WHERE tafelnummer IS NOT null AND bestelling_ID = '{0}'", bestelling_ID);
            return ExecuteSelectQuery(query, new SqlParameter[0]);
        }

        public void Finish_Order(int id)
        {
            string query = string.Format("UPDATE OrderItem SET status = 'Gereed' WHERE order_ID = '{0}'", id);
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        public void UnFinish_Order(object id)
        {
            string query = string.Format("UPDATE OrderItem SET status = 'Bezig' WHERE order_ID = '{0}'", id);
            ExecuteEditQuery(query, new SqlParameter[0]);
        }
    }
}
