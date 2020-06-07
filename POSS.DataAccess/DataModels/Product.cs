using POSS.DataAccess.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POSS.DataAccess.ProductModels
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description{get;set;}
        public String Group { get; set; }
        public String SubGroup { get; set; }
        public String Status { get; set; }
        public byte [] Image { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Vat { get; set; }
        public double Discount { get; set; }
        public String CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public String ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateDeleted { get; set; }
        public List<Cart> Products { get; set; }

    }
}
