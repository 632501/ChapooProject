using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class BestellingOrderItem
    {
        public int BestellingID;
        public string BestellingCommentaar;
        public DateTime? Datum;
        public int TafelID;
        public int OrderID;
        public int Aantal;
        public string OrderCommentaar;
        public int MenuID;
        public string Status;
        public int TafelNummer;
        public int WerknemerID;
        public string Categorie;
        public string WerknemerNaam;
        public string MenuItemNaam;
        public int Voorraad;
    }
}
