//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChapooModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bon
    {
        public int bon_ID { get; set; }
        public Nullable<System.DateTime> datum { get; set; }
        public decimal totaalprijs { get; set; }
        public Nullable<decimal> fooi { get; set; }
        public string commentaar { get; set; }
        public Nullable<int> bestel_ID { get; set; }
    }
}
