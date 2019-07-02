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
    public class Tafel_Service
    {
        private Tafel_DAO tafel_db = new Tafel_DAO();

        public bool Occupied(int tafelnummer)
        {
            return tafel_db.Occupied(tafelnummer);
        }

        public void GetAllTafels()
        {
            tafel_db.Db_Get_All_Tables();
        }

        public void EditStatus(int tafelnummer, bool bezet)
        {
            tafel_db.EditStatus(tafelnummer, bezet);
        }

        public List<Tafel> DB_Get_All_Tables()
        {
            return tafel_db.Db_Get_All_Tables();
        }
    }
}
