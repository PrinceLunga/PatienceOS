using System;
using System.Collections.Generic;
using System.Text;

namespace POSS.Models.SubGroup
{
    public class SubGroupModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public int GroupId { get; set; }
    }
}
