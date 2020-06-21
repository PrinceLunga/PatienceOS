using POSS.Models.Cart;
using POSS.Services.CartServices.Implementation;
using POSSModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSS.Services.CartServices.Interface
{
    public interface ICartService
    {
        public CartModel AddToCart(AddToCartModel model);
        public List<ViewCustomerCartModel> ViewCustomerCart(string Username);
        public string RemoveFromCart(int Id, string Username);
        public int GetCustomerId(string username);
        public void ClearCart();
        public double GetShoppingCartTotal();
        public List<CartModel> GetShoppingCartItems();
       public void UpdateCartItem(UpdateCartModel model);
       public  bool CartItemExists(int id);
    }
}
