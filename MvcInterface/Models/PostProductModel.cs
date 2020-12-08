using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcInterface.Models
{
    public class PostProductModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Group { get; set; }
        public String SubGroup { get; set; }
        public String Status { get; set; }
        public byte[] Image { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Vat { get; set; }
        public double Discount { get; set; }
    }
}
