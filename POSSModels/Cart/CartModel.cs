﻿using POSS.Models.Customer;
using POSSModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POSS.Models.Cart
{
    public class CartModel
    {
        [Key]
        public int Id { get; set; }
        public int NumberOfItems { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public double Discount { get; set; }
        public List<ProductModel> Products { get; set; }
        public DateTime DateCreated { get; set; }
        public int CustomerId { get; set; }
        public virtual CustomerModel Customer { get; set; }
    }
}