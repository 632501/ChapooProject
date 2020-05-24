using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;
using ChapooModel.Models;

namespace ChapooLogica
{
    public class OrderItem_Service
    {
        BestelGerecht_DAO bestelgerecht_dao = new BestelGerecht_DAO();

        public List<OrderItem> Orderstatus(int tafelnummer)
        {
            return bestelgerecht_dao.Db_Get_All_Tables(tafelnummer);
        }
    }
}
