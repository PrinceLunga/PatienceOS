using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using POSS.Services.CartServices.Interface;
using POSS.Models.Cart;
using POSSModels;
using POSS.DataAccess.DataModels;
using Microsoft.AspNetCore.Authorization;

namespace POSS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService cartService;
        public static string SessionKeyUserCartId = "";
        private readonly Customer customer = null;

        public CartController(ICartService _cartService, Customer _customer)
        {
            cartService = _cartService;
            customer = _customer;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CartModel>> GetShopppingCart()
        {
            return cartService.GetShoppingCartItems();
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductModel>> GetShopppingCartByUser()
        {
            // string Username = HttpContext.Session.GetString(SessionKeyUserCartId);
            string Username = SessionKeyUserCartId;
            return cartService.ViewCustomerCart(Username);
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductModel>> GetUserCart(AddToCartModel model)
        {
            return cartService.ViewCustomerCart(model.Username);
        }


        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CartModel>> PostOrder(AddToCartModel model)
        {
            model.Username = this.User.Identity.Name;

            if (model.Username != null)
            {
                CartModel results = cartService.AddToCart(model);
                //HttpContext.Session.SetString(SessionKeyUserCartId, results.UserCartId);
                SessionKeyUserCartId = results.UserCartId;
                return results;
            }
            else
                return new CartModel();
        }

    }
}