//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Creative.Model.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Discount
    {
        public int DiscountId { get; set; }
        public string OfferName { get; set; }
        public int Category { get; set; }
        public System.DateTime ApplicableFrom { get; set; }
        public System.DateTime ApplicableTo { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Discount Discount1 { get; set; }
        public virtual Discount Discount2 { get; set; }
    }
}
