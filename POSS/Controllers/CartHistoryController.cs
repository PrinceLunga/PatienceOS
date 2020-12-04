
using Microsoft.AspNetCore.Mvc;
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
        
          private readonly ICartHistoryService _cartservice;

            public CartHistoryController(ICartHistoryService cartservice)
            {
                _cartservice = cartservice;
            }

        [HttpGet]
        public ActionResult<IEnumerable<CartHistoryModel>> ViewCartHistory()
        {
            return _cartservice.ViewCartHistory();
        }
    }
}
