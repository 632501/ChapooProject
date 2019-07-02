using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;
using ChapooModel.Models;

namespace ChapooDAL
{
    public class BestelGerecht_DAO : Base
    {

        public string conn = "Data Source=den1.mssql7.gear.host; Initial Catalog = chapoo1819sdb15; User=chapoo1819sdb15; Password=Uh6Q-7?9ykHi";
        protected SqlConnection con;

        public List<OrderItem> Db_Get_All_Tables(int tafelnummer)
        {
            string query = "SELECT status FROM [OrderItem] where tafelnummer =" + tafelnummer + "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadAllTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderItem> ReadAllTables(DataTable dataTable)
        {
            List<OrderItem> items = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem item = new OrderItem()
                {
                    Status = (string)dr["status"]
                };
                items.Add(item);
            }
            return items;
        }
        public string OrderStatus(int tableNumber)
        {
            string status = " ";
            string query = "Select status from OrderItem where tafelnummer = '" + tableNumber + "'";
            con = new SqlConnection(conn);

            con.Open();

            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader dr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dr.Read();
            
            status = (string)dr["status"];
            

            return status;
        }
    } 
}
