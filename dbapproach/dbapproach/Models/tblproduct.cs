//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dbapproach.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblproduct
    {
        public int productid { get; set; }
        public string productname { get; set; }
        public decimal price { get; set; }
        public Nullable<int> category_CategoryId { get; set; }
    
        public virtual tblcategory tblcategory { get; set; }
    }
}
