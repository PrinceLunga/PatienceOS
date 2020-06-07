using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POSS.Models.Cart
{
    public class AddToCartModel
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
    }
}
