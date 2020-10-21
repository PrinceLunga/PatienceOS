using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using POSS.Services.CartServices.Interface;
using POSS.Models.Cart;
using POSSModels;
using POSS.DataAccess.DataModels;
using Microsoft.EntityFrameworkCore;

namespace POSS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService cartService;
        private readonly Customer customer = null;

        public CartController(ICartService _cartService)
        {
            cartService = _cartService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<CartModel>> GetShopppingCart()
        {
            return cartService.GetShoppingCartItems();
        }

        [HttpGet("{Username}")]
        public ActionResult<IEnumerable<ViewCustomerCartModel>> GetShoppingCartByUser(string Username)
        {
            return cartService.ViewCustomerCart(Username);
        }

        [HttpGet]
        public ActionResult<IEnumerable<ViewCustomerCartModel>> GetUserCart(AddToCartModel model)
        {
            return cartService.ViewCustomerCart(model.Username);
        }


        [HttpPost]
        public ActionResult<CartModel> PostOrder(AddToCartModel model)
        {
            if (model.Username != null)
            {
                CartModel results = cartService.AddToCart(model);
                return results;
            }
            else
                return new CartModel();
        }

        [HttpPut("{id}")]
        [AcceptVerbs("POST", "PUT")]
        public ActionResult<UpdateCartModel> UpdateCartItem(int id, [FromBody] UpdateCartModel model)
        {
            try
            {
                if ((model == null) || (model.Id == 0))
                {
                    return NotFound();
                }
                cartService.UpdateCartItem(model);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CartItemExists(id))
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

        [HttpPost]
        public ActionResult<ProductModel> RemoveCartItem(AddToCartModel model)
        {
            if (model.Username == null)
            {
                return NotFound();
            }
            cartService.RemoveFromCart(model.Id, model.Username);
            return RedirectToAction("GetShopppingCartByUser");
           
        }

        private bool CartItemExists(int id)
        {
            return cartService.CartItemExists(id);
        }
    }
}