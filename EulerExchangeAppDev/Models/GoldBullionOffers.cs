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
    
    public partial class GoldBullionOffers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoldBullionOffers()
        {
            this.GoldBullionOfferBids = new HashSet<GoldBullionOfferBids>();
        }
    
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public Nullable<float> Price { get; set; }
        public Nullable<float> Weight { get; set; }
        public Nullable<float> Carat { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
    
        public virtual Companies Companies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoldBullionOfferBids> GoldBullionOfferBids { get; set; }
    }
}
