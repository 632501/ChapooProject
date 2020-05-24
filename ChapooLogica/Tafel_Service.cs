using ChapooDAL;
using ChapooModel;
using ChapooModel.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooLogica
{
    public class Tafel_Service
    {
        private Tafel_DAO tafel_DAO = new Tafel_DAO();


        public List<Tafel> getTables()
        {
            List<Tafel> tafels = tafel_DAO.Get_All_Tables();
            return tafels;
        }

        public void EditStatus(int tafelnummer, bool status)
        {
            tafel_DAO.EditStatus(tafelnummer, status);
        }

        public string CheckOrderStatus(int tafelnummer)
        {
            return tafel_DAO.CheckOrderStatus(tafelnummer);
        }
    }
}