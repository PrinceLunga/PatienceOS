using POSS.DataAccess.Context;
using POSS.DataAccess.ProductModels;
using POSS.Models.SubGroup;
using POSS.Services.SubGroupServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSS.Services.SubGroupServices.Implementation
{
    public class SubGroupLogic : ISubGroupLogic
    {
        private readonly POSSDbContext dbContext;
        public SubGroupLogic(POSSDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public string Add_SubGroup(SubGroupModel model)
        {
            try
            {
                using (dbContext)
                {
                    var subGroup = new SubGroup
                    {
                        SubGroup_Id = model.Id,
                        Name = model.Name,
                        Description = model.Description,
                        GroupId = model.GroupId,
                        CreatedBy = "Prince Lunga",
                        DateCreated = DateTime.Now
                    };

                    dbContext.SubGroups.Add(subGroup);
                    dbContext.SaveChanges();
                    return $"Sub-Group {model.Name} successfully added !";
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
            
        }

        public string DeleteSubGroup(int Id)
        {
            throw new NotImplementedException();
        }

        public SubGroupModel FindSubGroupById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<SubGroupModel> GetSubGroups()
        {
            using(dbContext)
            {
                return dbContext.SubGroups.Select(x => new SubGroupModel
                {
                    Id = x.SubGroup_Id,
                    Name = x.Name,
                    Description = x.Description
                }).ToList();
            }
        }

        public bool SubGroupExists(int id)
        {
            using(dbContext)
            {
                var subGroup = dbContext.SubGroups.Find(id);

                if(subGroup != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string UpdateSubGroup(SubGroupModel model)
        {
            throw new NotImplementedException();
        }
    }
}
