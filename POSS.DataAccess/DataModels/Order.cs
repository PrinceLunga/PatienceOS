using Microsoft.EntityFrameworkCore;
using POSS.DataAccess.ProductModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POSS.DataAccess.DataModels
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public int Items { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }
        public double VAT { get; set; }
        public string CartUserId { get; set; }
    }
}
