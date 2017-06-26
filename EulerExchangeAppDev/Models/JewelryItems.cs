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
    
    public partial class JewelryItems
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JewelryItems()
        {
            this.JewelryItemsImageURL = new HashSet<JewelryItemsImageURL>();
            this.OrderJewelryItems = new HashSet<OrderJewelryItems>();
            this.Gemstones = new HashSet<Gemstones>();
        }
    
        public int Id { get; set; }
        public int CategoryJewelryId { get; set; }
        public int CompanyId { get; set; }
        public Nullable<float> Weight { get; set; }
        public Nullable<float> Price { get; set; }
        public Nullable<float> Millem { get; set; }
        public Nullable<float> Carat { get; set; }
        public Nullable<int> Pieces { get; set; }
        public string Size { get; set; }
        public Nullable<float> Length { get; set; }
        public Nullable<float> Thick { get; set; }
        public Nullable<float> Wide { get; set; }
        public string Comment { get; set; }
    
        public virtual Companies Companies { get; set; }
        public virtual JewelryCategories JewelryCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JewelryItemsImageURL> JewelryItemsImageURL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderJewelryItems> OrderJewelryItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gemstones> Gemstones { get; set; }
    }
}
