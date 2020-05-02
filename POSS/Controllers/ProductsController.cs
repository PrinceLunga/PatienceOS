using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using POSS.DataAccess.Context;
using POSS.DataAccess.ProductModels;
using POSS.Models.Product;
using POSS.Services.Implementation;
using POSS.Services.Interfaces;
using POSSModels;

namespace POSS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductLogic _context;

        public ProductsController(IProductLogic context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public ActionResult<IEnumerable<ProductModel>> GetProducts()
        {
            return _context.GetProducts  ();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public ActionResult<ProductModel> GetProduct(int id)
        {
            var product = _context.FindProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        [AcceptVerbs("POST", "PUT")]
        public  ActionResult<ProductModel> PutProduct(int id, [FromBody] ProductModel model)
        {
            try
            {
                if ((model == null) || (model.Id == 0))
                {
                    return NotFound();
                }
                _context.UpdateProduct(model);
                
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
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

        // POST: api/Products
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        [AcceptVerbs("POST")]
        public  ActionResult<ProductModel> PostProduct([FromForm] ProductModel product)
        {
            string results =  _context.Add_Product(product);
            return product;
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductModel>> DeleteProduct(int id)
        {
            var product =  _context.FindProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            _context.DeleteProduct(id);
            return product;
        }

        private bool ProductExists(int id)
        {
            return _context.ProductExists(id);
        }
    }
}
