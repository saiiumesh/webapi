using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace CodeFirstApproach.Models
{
    [Table("tblproducts")]
    public class products
    {
        [Key]
        public int productid { get; set; }
        public string productname { get; set; }
        public decimal price { get; set; }


        //foreign key
        public Category category { get; set; }
    }
}