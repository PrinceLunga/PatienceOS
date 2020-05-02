using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace POSSModels
{
    public class ProductModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Group { get; set; }
        public String SubGroup { get; set; }
        public String Status { get; set; }
        public byte [] Image { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }
    }
}
