using POSS.DataAccess.ProductModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POSS.DataAccess.DataModels
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public int NumberOfItems { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public double Discount { get; set; }
        public List<Product> Products { get; set; }
        public DateTime DateCreated { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
