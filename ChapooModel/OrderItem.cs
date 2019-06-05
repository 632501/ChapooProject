using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel.Models
{
    public class OrderItem
    {
        public List<MenuItem> menuItem { get; set; }
        public int Aantal { get; set; }
        public string comment { get; set; }
        public string Status { get; set; }
    }
}
