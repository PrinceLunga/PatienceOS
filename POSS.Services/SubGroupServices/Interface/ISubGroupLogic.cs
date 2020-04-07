using POSS.Models.SubGroup;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSS.Services.SubGroupServices.Interface
{
    public interface ISubGroupLogic
    {
        public String Add_SubGroup(SubGroupModel model);
        public SubGroupModel FindSubGroupById(int Id);
        public List<SubGroupModel> GetSubGroups();
        public String DeleteSubGroup(int Id);
        public String UpdateSubGroup(SubGroupModel model);
        public bool SubGroupExists(int id);
    }
}
