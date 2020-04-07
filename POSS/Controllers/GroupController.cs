using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POSS.Models.Group;
using POSS.Services.GroupService.Interface;

namespace POSS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IGroupLogic _context;

        public GroupController(IGroupLogic context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public ActionResult<IEnumerable<GroupModel>> GetGroups()
        {
            return _context.GetGroups();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public ActionResult<GroupModel> GetProduct(int id)
        {
            var group = _context.FindGroupById(id);

            if (group == null)
            {
                return NotFound();
            }

            return group;
        }

        [HttpPost]
        public async Task<ActionResult<GroupModel>> PostGroup(GroupModel model)
        {
            _context.Add_Group(model);
            return CreatedAtAction("GetGroups", new { id = model.Id }, model);
        }
    }
}