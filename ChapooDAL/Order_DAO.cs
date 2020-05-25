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
        private Menu_DAO menu_DAO = new Menu_DAO();
        private Login_DAO login_DAO = new Login_DAO();


        public List<BestellingOrderItem> Get_All_Kitchen_Orders(bool showFinished)
        {
            string query = string.Format("SELECT b.bestelling_id, b.commentaar as BestellingCommentaar, b.datum, b.tafel_id, o.bestelling_id, o.aantal, o.commentaar as OrderCommentaar,o.gerecht_id,o.order_id,o.status,o.tafel_id,o.werknemer_id,m.categorie,m.naam AS MenuItemNaam,m.voorraad, i.naam AS WerknemerNaam FROM Bestelling AS b JOIN Bestel_Gerecht AS o ON o.bestelling_id = b.bestelling_id JOIN Menu AS m ON m.menu_id = o.gerecht_id JOIN Inlog AS i ON i.werknemer_id = o.werknemer_id WHERE datum > CAST(CURRENT_TIMESTAMP AS DATE) AND categorie != 'dranken'");
            query += !showFinished ? "" : " AND o.status != 'Gereed'";
            return readOrdersWithOrderItems(ExecuteSelectQuery(query, new SqlParameter[0]));

        }
        public List<BestellingOrderItem> Get_All_Bar_Orders(bool showFinished)
        {
            string query = string.Format("SELECT b.bestelling_id, b.commentaar as BestellingCommentaar, b.datum, b.tafel_id, o.bestelling_id, o.aantal, o.commentaar as OrderCommentaar,o.gerecht_id,o.order_id,o.status,o.tafel_id,o.werknemer_id,m.categorie,m.naam AS MenuItemNaam,m.voorraad, i.naam AS WerknemerNaam FROM Bestelling AS b JOIN Bestel_Gerecht AS o ON o.bestelling_id = b.bestelling_id JOIN Menu AS m ON m.menu_id = o.gerecht_id JOIN Inlog AS i ON i.werknemer_id = o.werknemer_id WHERE datum > CAST(CURRENT_TIMESTAMP AS DATE) AND categorie = 'dranken'");
            query += !showFinished ? "" : " AND o.status != 'Gereed'";
            return readOrdersWithOrderItems(ExecuteSelectQuery(query, new SqlParameter[0]));
        }

        public List<Bestelling> Get_Order_Per_Table(int tafelnummer)
        {
            string query = string.Format("SELECT * FROM Bestelling WHERE tafel_id = '{0}' ", tafelnummer);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<BestellingOrderItem> readOrdersWithOrderItems(DataTable dataTable)
        {
            List<BestellingOrderItem> orders = new List<BestellingOrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                BestellingOrderItem order = new BestellingOrderItem()
                {
                    BestellingID = (int)dr["bestelling_id"],
                    OrderCommentaar = (dr["OrderCommentaar"] == null) ? string.Empty : dr["OrderCommentaar"].ToString(),
                    Datum = dr["datum"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["datum"]),
                    TafelID = (int)dr["tafel_id"],
                    OrderID = (int)dr["order_id"],
                    Aantal = (int)dr["aantal"],
                    BestellingCommentaar = (dr["BestellingCommentaar"] == null) ? string.Empty : dr["BestellingCommentaar"].ToString(),
                    Status = dr["status"].ToString(),
                    TafelNummer = (int)dr["tafel_id"],
                    Categorie = (dr["categorie"] == null) ? string.Empty : dr["categorie"].ToString(),
                    MenuID = (int)dr["gerecht_id"],
                    Voorraad = (int)dr["voorraad"],
                    WerknemerID = (int)dr["werknemer_id"],
                    MenuItemNaam = (dr["MenuItemNaam"] == null) ? string.Empty : dr["MenuItemNaam"].ToString(),
                    WerknemerNaam = (dr["WerknemerNaam"] == null) ? string.Empty : dr["WerknemerNaam"].ToString()
                };
                orders.Add(order);
            }

            return orders;
        }
        private List<OrderItem> readOrderItems(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                    order_id = (int)dr["order_ID"],
                    Aantal = (int)dr["aantal"],
                    Comment = (dr["commentaar"] == null) ? string.Empty : dr["commentaar"].ToString(),
                    menuItem = menu_DAO.GetSingleItem((int)dr["gerecht_id"]),
                    Status = dr["status"].ToString(),
                    tafel_id = (int)dr["tafel_id"],
                    Werknemer = login_DAO.GetEmployee((int)dr["werknemer_id"])
                };
                orderItems.Add(orderItem);
            }
            return orderItems;
        }
        private List<Bestelling> ReadOrders(DataTable dataTable)
        {
            List<Bestelling> bestellingen = new List<Bestelling>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bestelling bestelling = new Bestelling()
                {
                    bestelling_id = (int)dr["bestelling_id"],
                    commentaar = (String)(dr["commentaar"].ToString()),
                    datum = (DateTime)dr["datum"],
                    tafel_id = (int)dr["tafel_id"]

                };
                bestellingen.Add(bestelling);
            }
            return bestellingen;
        }

        public List<OrderItem> Get_Order_Items_Per_Table(int tafelnummer, int bestelling_ID)
        {
            string query = string.Format("SELECT * FROM Bestel_Gerecht WHERE tafel_id = '{0}' AND bestelling_id = '{1}'",tafelnummer, bestelling_ID);
            return readOrderItems(ExecuteSelectQuery(query, new SqlParameter[0]));

        }
        public void Finish_Order(int id)
        {
            string query = string.Format("UPDATE Bestel_Gerecht SET status = 'Gereed' WHERE order_id = '{0}'", id);
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        public void UnFinish_Order(int id)
        {
            string query = string.Format("UPDATE Bestel_Gerecht SET status = 'Bezig' WHERE order_id = '{0}'", id);
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        public void DeleteOrderItem(int orderItem)
        {
            string query = string.Format("DELETE FROM Bestel_Gerecht WHERE order_id = '{0}'", orderItem);
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        public void DeleteOrderItemByID(int bestellingID)
        {
            string query = string.Format("DELETE FROM Bestel_Gerecht WHERE bestelling_id = '{0}'", bestellingID);
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        // Bon gedeelte
        public void Paid(int tafel_ID, string date, string amountString, string tipString, string comment, int bestelling_ID, string paymentType)
        {
            string queryPaid = "UPDATE Bestelling SET betaald = 1 FROM Bestelling tafel_id = '" + tafel_ID + "' AND betaald =" + false;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(queryPaid, sqlParameters);

            string queryBon = "SET IDENTITY_INSERT Bon OFF INSERT INTO Bon(datum, totaalprijs, fooi, commentaar, bestelling_id, betaaltype) values(" + date + ", CONVERT(varchar, CAST('" + amountString + "' AS money)), CONVERT(varchar, CAST('" + tipString + "' AS money)), '" + comment + "', '" + bestelling_ID + "', '" + paymentType + "')";
            ExecuteEditQuery(queryBon, sqlParameters);
        }

        public Bestelling Orders(int tafel_ID)
        {
            string query = "SELECT O.aantal, O.bestelling_id, M.naam, M.prijs, M.btwPercentage FROM Bestel_Gerecht AS O JOIN Menu AS M ON O.gerecht_id = M.menu_id JOIN Bestelling AS B ON O.bestelling_id = B.bestelling_id WHERE B.tafel_id = " + tafel_ID + " AND B.betaald = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadBonOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        private Bestelling ReadBonOrders(DataTable dataTable)
        {
            Bestelling Orders = new Bestelling();
            Orders.orderItems = new List<OrderItem>();
            MenuItem m = new MenuItem();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    OrderItem oI = new OrderItem()
                    {
                        Aantal = (int)dr["aantal"],
                        bestelling_id = (int)dr["bestelling_id"]
                    };
                    m.prijs = (decimal)dr["prijs"];
                    m.naam = (string)dr["naam"];
                    m.btwPercentage = (int)dr["btwPercentage"];

                    oI.menuItem = m;

                    Orders.orderItems.Add(oI);
                }
                Orders.bestelling_id = Orders.orderItems[0].bestelling_id;
            }
            return Orders;
        }
    }
}
