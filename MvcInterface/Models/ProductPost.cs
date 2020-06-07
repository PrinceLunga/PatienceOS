using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MvcInterface.Models
{

    [DataContract]
    public class ProductPost
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
        public string Image { get; set; }
        [DataMember]
        public String Price { get; set; }
        [DataMember]
        public double Vat { get; set; }
        [DataMember]
        public String Quantity { get; set; }
    }
}
