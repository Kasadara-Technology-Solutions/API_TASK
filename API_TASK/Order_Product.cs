//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_TASK
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_Product
    {
        public int ID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> ProductCode { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<decimal> PriceEach { get; set; }
    
        public virtual Productline Productline { get; set; }
        public virtual Product Product { get; set; }
    }
}
