using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POSS.Models.Delivery;
using POSS.Services.DeliveryServices.Interface;

namespace POSS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DeliveryController : Controller
    {
        private readonly IDelivery _context;

        public DeliveryController(IDelivery context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public ActionResult<IEnumerable<GetAllDeliveryAddressesModel>> GetAllDeliveries()
        {
            return _context.GetAllDeliveryAddresses();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public ActionResult<GetCustomerDeliveryAddressModel> GetCustomerDelivery(int id)
        {
            var delivery = _context.GetCustomerDeliveryAddress(id);

            if (delivery == null)
            {
                return NotFound();
            }

            return delivery;
        }

        [HttpPost]
        public async Task<ActionResult<AddDeliveryAddressModel>> PostDelivery(AddDeliveryAddressModel model)
        {
            _context.AddDeliveryAddress(model);
            return CreatedAtAction("GetAllDeliveries", new { id = model.Id }, model);
        }

        [HttpPut("{id}")]
        [AcceptVerbs("POST", "PUT")]
        public ActionResult<UpdateDeliveryAddressModel> PutDelivery(int id, UpdateDeliveryAddressModel model)
        {
            try
            {
                if ((model == null) || (model.Id == 0))
                {
                    return NotFound();
                }
                _context.UpdateDeliveryAddress(model);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliveryExists(id))
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

        private bool DeliveryExists(int id)
        {
            return _context.DeliveryExists(id);
        }
    }
}
