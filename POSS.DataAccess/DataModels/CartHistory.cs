using POSS.DataAccess.ProductModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POSS.DataAccess.DataModels
{
    public class CartHistory
    {
        [Key]
        public int CartHistoryId { get; set; }
        public string UserCartId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }
        public DateTime DateRecorded { get; set; }
        public int ProductId { get; set; }
       // public virtual Product Product { get; set; }
    }
}
