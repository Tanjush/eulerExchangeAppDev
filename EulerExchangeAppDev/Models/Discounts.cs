//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EulerExchangeAppDev.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Discounts
    {
        public int Id { get; set; }
        public Nullable<decimal> Persent { get; set; }
        public Nullable<decimal> FixPrice { get; set; }
        public Nullable<decimal> MinOrderGram { get; set; }
        public Nullable<decimal> MinOrderPrice { get; set; }
        public System.DateTime PeriodFrom { get; set; }
        public System.DateTime PeriodTo { get; set; }
        public int CompanyId { get; set; }
    
        public virtual Companies Companies { get; set; }
    }
}