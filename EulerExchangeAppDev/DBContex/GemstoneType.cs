//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EulerExchangeAppDev.DBContex
{
    using System;
    using System.Collections.Generic;
    
    public partial class GemstoneType
    {
        public GemstoneType()
        {
            this.RingGemstoneType = new HashSet<RingGemstoneType>();
            this.Rings = new HashSet<Rings>();
        }
    
        public int Id { get; set; }
        public string Number { get; set; }
        public string Decription { get; set; }
        public Nullable<decimal> Carats { get; set; }
    
        public virtual ICollection<RingGemstoneType> RingGemstoneType { get; set; }
        public virtual ICollection<Rings> Rings { get; set; }
    }
}