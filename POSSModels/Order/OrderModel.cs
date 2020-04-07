using POSS.Models.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POSS.Models.Order
{
    public class OrderModel
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Number { get; set; }
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public int CustomerId { get; set; }
        public virtual CustomerModel Customer { get; set; }
    }
}
