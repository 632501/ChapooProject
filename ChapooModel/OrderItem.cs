using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel.Models
{
    public class OrderItem
    {
        public int order_ID { get; set; }
        public int bestelling_ID { get; set;}
        public MenuItem menuItem { get; set; }
        public int TafelNummer { get; set; }
        public Inlog Werknemer { get; set; }
        public int Aantal { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }
        
    }
}
