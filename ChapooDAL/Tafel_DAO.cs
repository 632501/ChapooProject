using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ChapooModel;
using ChapooModel.Models;

namespace ChapooDAL
{
    public class Tafel_DAO : Base
    {
        private List<Tafel> ReadTafels(DataTable dataTable)
        {
            List<Tafel> tafels = new List<Tafel>();
            
            foreach (DataRow dr in dataTable.Rows)
            {
                Tafel tafel = new Tafel()
                {
                    tafel_id = (int)dr["tafel_id"],
                    bezet = (bool)dr["bezet"]
                    
                };
                tafels.Add(tafel);
            }
            return tafels;
        }

        private Tafel ReadTafel(DataTable dataTable) {
            DataRow dr = dataTable.Rows[0];
            Tafel tafel = new Tafel() {
                tafel_id = (int)dr["tafel_id"],
                bezet = (bool)dr["bezet"]
            };
            return tafel;
        }
        public List<Tafel> Get_All_Tables() {
            string query = string.Format("SELECT * FROM Tafel");
            return ReadTafels(ExecuteSelectQuery(query, new SqlParameter[0]));
        }

        public void EditStatus(int tableNumber, bool status)
        {

            int state = 0;
            if(status == true)
            {
                state = 1;
            }

            string query = "UPDATE Tafel Set bezet = " + state + " where tafel_id = " + tableNumber;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public string CheckOrderStatus(int tableNumber)
        {
            string status = " ";
            try
            {
                string query = "Select status from Bestel_Gerecht where tafel_id = '" + tableNumber + "'";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                DataTable table = ExecuteSelectQuery(query, sqlParameters);
                DataRow dr = table.Rows[0];

                status = (string)dr["status"];
                

                return status;
            } catch
            {
                return status;
            }
        }
    }
}
