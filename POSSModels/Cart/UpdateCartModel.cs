using POSS.Models.Customer;
using POSSModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POSS.Models.Cart
{
    public class UpdateCartModel
    {
        [Key]
        public int Id { get; set; }
        public string UserCartId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }
        public int ProductId { get; set; }
        public virtual ProductModel Product { get; set; }
        public int CustomerId { get; set; }
        public virtual CustomerModel Customer { get; set; }
    }
}
