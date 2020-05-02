using POSS.Models.Cart;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSS.Services.CartService.Interface
{
    public interface ICartService
    {
        public string AddToCart(CartModel model);
        public string UpdateCart(CartModel model);
        public List<CartModel> ViewCustomerCart(string Username);
        public string RemoveFromCart(CartModel model);
    }
}
