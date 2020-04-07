using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POSS.Models.SubGroup;
using POSS.Services.SubGroupServices.Interface;

namespace POSS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubGroupController : ControllerBase
    {
        private readonly ISubGroupLogic _context;

        public SubGroupController(ISubGroupLogic context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public ActionResult<IEnumerable<SubGroupModel>> GetSubGroups()
        {
            return _context.GetSubGroups();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public ActionResult<SubGroupModel> GetProduct(int id)
        {
            var group = _context.FindSubGroupById(id);

            if (group == null)
            {
                return NotFound();
            }

            return group;
        }

        [HttpPost]
        public async Task<ActionResult<SubGroupModel>> PostSubGroup(SubGroupModel model)
        {
            _context.Add_SubGroup(model);
            return CreatedAtAction("GetSubGroups", new { id = model.Id }, model);
        }
    }
}