using POSS.DataAccess.Context;
using POSS.Models.Group;
using POSS.DataAccess.ProductModels;
using System;
using System.Collections.Generic;
using System.Text;
using POSS.Services.GroupService.Interface;
using System.Linq;

namespace POSS.Services.GroupService.Implementation
{
    public class GroupLogic : IGroupLogic
    {
        private readonly POSSDbContext dbContext;

        public GroupLogic(POSSDbContext context)
        {
            dbContext = context;
        }
        public string Add_Group(GroupModel model)
        {
            try
            {
                using(dbContext)
                {
                    var group = new Group
                    {
                        Id = model.Id,
                        Name = model.Name,
                        Description = model.Description,
                        CreatedBy = "Prince Lunga",
                        DateCreated = DateTime.Now
                        
                    };
                    dbContext.Groups.Add(group);
                    dbContext.SaveChanges();
                    return $"Group {model.Name} successfully added !";
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }

        public string DeleteGroup(int Id)
        {
            try
            {
                using (dbContext)
                {
                    var group = dbContext.Groups.Find(Id);
                    dbContext.Remove(group);
                    dbContext.SaveChanges();
                    return "Deleted Successfully !";
                }

            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public GroupModel FindGroupById(int Id)
        {
           using(dbContext)
            {
                return dbContext.Groups.Select( x => new GroupModel 
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description
                } ).FirstOrDefault(b => b.Id == Id);
            }
        }

        public List<GroupModel> GetGroups()
        {
            using(dbContext)
            {
                return dbContext.Groups.Select(x => new GroupModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description
                }).ToList();
            }
        }

        public bool GroupExists(int id)
        {
            using(dbContext)
            {
                var group = dbContext.Groups.Find(id);

                if(group != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string UpdateGroup(GroupModel model)
        {
            try
            {
                using(dbContext)
                {
                    var group = dbContext.Groups.Find(model.Id);

                    group.Name = model.Name;
                    group.Description = model.Description;

                    dbContext.SaveChanges();
                    return $"Group {model.Name} successfully created !";
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }
    }
}
