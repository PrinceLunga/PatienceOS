
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POSS.DataAccess.DataModels;
using POSS.Models.CartHistory;
using POSS.Services.CartHistoryService;
using POSS.Services.CartHistoryService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace POSS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class CartHistoryController
    {
        
          private readonly ICartHistoryService _icartHistoryService;

            public CartHistoryController(ICartHistoryService icartHistoryService)
            {
                _icartHistoryService = icartHistoryService;
            }

        [HttpGet]
        public ActionResult<IEnumerable<CartHistoryModel>> ViewCartHistory()
        {
            return _icartHistoryService.ViewCartHistory();
        }

        [HttpPost]
        public async Task<ActionResult<CartHistoryModel>> AddToCartHistory (CartHistoryModel model)
        {
            
            if(model.CartHistoryId == 0)
            {
                return null;
            }
            _icartHistoryService.AddToCartHistory(model);
            return model;
        }

        [HttpPut("{id}")]
        [AcceptVerbs("POST", "PUT")]
        public ActionResult<CartHistoryModel> UpdateCartHistory(CartHistoryModel model)
        {
            try
            {
                if (model != null)
                {
                    _icartHistoryService.UpdateCartHistory(model);
                    return model;
                }
                

            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return null;
        }

        [HttpPost]
        public string RemoveCartHistory(CartHistoryModel model)
        {
            try
            {
                if (model != null)
                {
                    _icartHistoryService.DeleteCartHistory(model);
                    return "Delete Action Successful";
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return null;
        }

        [HttpGet("{id}")]
        public ActionResult<CartHistoryModel> GetHistoryById(int id)
        {
            var history = _icartHistoryService.FindHistoryById(id);

            if (history == null)
            {
                return null;
            }

            return history;
        }

    }
}
 