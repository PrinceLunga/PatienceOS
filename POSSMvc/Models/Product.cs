using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace POSSMvc.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Group { get; set; }
        public String SubGroup { get; set; }
        public String Status { get; set; }
        public byte[] Image { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }
        public string Message { get; set; }
    }
}
