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
    
    public partial class SetsWatchesSunglasses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SetsWatchesSunglasses()
        {
            this.SetsWatchesSunglassesImageURL = new HashSet<SetsWatchesSunglassesImageURL>();
        }
    
        public int Id { get; set; }
        public string Number { get; set; }
        public string Decription { get; set; }
        public Nullable<decimal> Carat { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public int CompanyId { get; set; }
    
        public virtual Companies Companies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SetsWatchesSunglassesImageURL> SetsWatchesSunglassesImageURL { get; set; }
    }
}
