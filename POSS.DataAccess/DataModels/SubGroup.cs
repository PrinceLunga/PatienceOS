using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POSS.DataAccess.ProductModels
{
    public class SubGroup
    {
        [Key]
        public int SubGroup_Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public string CreatedBy { get; set; }

        public DateTime DateCreated { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime EndDate { get; set; }

        public int GroupId { get; set; }

        public Group group { get; set; }
    }
}
