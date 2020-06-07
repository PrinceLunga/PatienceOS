using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcInterface.Models
{
    public class CartModel
    {
        [Key]
        public string Id { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
        public double Discount { get; set; }
        public DateTime DateCreated { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CustomerId { get; set; }
        public CustomerModel Customer { get; set; }
    }
}
