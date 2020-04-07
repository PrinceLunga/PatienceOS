using POSS.Models.Group;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSS.Services.GroupService.Interface
{
    public interface IGroupLogic
    {
        public String Add_Group(GroupModel model);
        public GroupModel FindGroupById(int Id);
        public List<GroupModel> GetGroups();
        public String DeleteGroup(int Id);
        public String UpdateGroup(GroupModel model);
        public bool GroupExists(int id);
    }
}
