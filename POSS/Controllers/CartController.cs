using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using POSS.Services.CartServices.Interface;
using POSS.Models.Cart;
using POSSModels;
using POSS.DataAccess.DataModels;


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
        public ActionResult<IEnumerable<ProductModel>> GetShoppingCartByUser(string Username)
        {
            return cartService.ViewCustomerCart(Username);
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductModel>> GetUserCart(AddToCartModel model)
        {
            return cartService.ViewCustomerCart(model.Username);
        }


        [HttpPost]
        public async  Task<ActionResult<CartModel>> PostOrder(AddToCartModel model)
        {
            if (model.Username != null)
            {
                CartModel results =  cartService.AddToCart(model);
                return results;
            }
            else
                return new CartModel();
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
    }
}