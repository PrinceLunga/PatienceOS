using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Threading.Tasks;

namespace MvcInterface.Models
{
    [DataContract]
    public class AddProductModel
    {
        [Key]
        public string Id { get; set; }
        [DataMember]
        public String Name { get; set; }
        [DataMember]
        public String Description { get; set; }
        [DataMember]
        public String Group { get; set; }
        [DataMember]
        public String SubGroup { get; set; }
        [DataMember]
        public String Status { get; set; }
        [DataMember]
        public IFormFile Image { get; set; }
        [DataMember]
        public String Price { get; set; }
        [DataMember]
        public double VAt { get; set; }
        [DataMember]
        public String Quantity { get; set; }

        [DataMember]
        public double Discount { get; set; }
        
        [DataMember]
        public string CreatedBy { get; set; }
        [DataMember]
        public DateTime DateCreated { get; set; }
    }
}
