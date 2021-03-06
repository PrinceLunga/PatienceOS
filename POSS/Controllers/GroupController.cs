﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POSS.Models.Group;
using POSS.Services.GroupService.Interface;

namespace POSS.Controllers
{
    [Route("api/[controller]/[action]")]
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
        public ActionResult<GroupModel> GetGroup(int id)
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

        [HttpPut("{id}")]
        [AcceptVerbs("POST", "PUT")]
        public ActionResult<GroupModel> PutGroup(int id, GroupModel model)
        {
            try
            {
                if ((model == null) || (model.Id == 0))
                {
                    return NotFound();
                }
                _context.UpdateGroup(model);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return model;
        }

        [HttpPut("{id}")]
        [AcceptVerbs("POST", "PUT")]
        public ActionResult<GroupModel> DeleteGroup(int id, GroupModel model)
        {
            try
            {
                if ((model == null) || (model.Id == 0))
                {
                    return NotFound();
                }
                _context.DeleteGroup(id);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return model;
        }

        private bool GroupExists(int id)
        {
            return _context.GroupExists(id);
        }
    }
}