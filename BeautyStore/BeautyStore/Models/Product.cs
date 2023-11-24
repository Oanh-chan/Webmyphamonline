//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeautyStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Comments = new HashSet<Comment>();
            this.FavoriteProducts = new HashSet<FavoriteProduct>();
            this.OrderDetails = new HashSet<OrderDetail>();
            this.StepsToUses = new HashSet<StepsToUse>();
        }
    
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Technology { get; set; }
        public Nullable<decimal> IntialPrice { get; set; }
        public decimal Price { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Desciption { get; set; }
        public int BrandID { get; set; }
        public string OriginOfBrand { get; set; }
        public string OriginOfProduction { get; set; }
        public string SkinType { get; set; }
        public string Attribute { get; set; }
        public string Sex { get; set; }
        public string SkinProblem { get; set; }
        public string MainIngredients { get; set; }
        public string FullIngredients { get; set; }
        public int amount { get; set; }
        public int CategoryID { get; set; }
    
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FavoriteProduct> FavoriteProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StepsToUse> StepsToUses { get; set; }
    }
}