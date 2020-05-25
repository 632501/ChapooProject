namespace ChapooModel
{
    using ChapooModel.Models;
    using System;
    using System.Collections.Generic;
    
    public partial class Bestelling
    {

        public Inlog werknemer { get; set; }
        public int bestelling_id { get; set; }
        public int tafel_id { get; set; }
        public Nullable<System.DateTime> datum { get; set; }
        public string commentaar { get; set; }
        public bool betaald { get; set; }
        public List<OrderItem> orderItems { get; set; }
    }
}
