using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace POSSMvc.Models
{
    public class UpdateProductcs
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Group { get; set; }
        public String SubGroup { get; set; }
        public String Status { get; set; }
        public byte[] Image { get; set; }
        public String Price { get; set; }
        public int Quantity { get; set; }
        public String CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public String ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateDeleted { get; set; }
    }
}
