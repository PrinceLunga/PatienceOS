using POSS.DataAccess.Context;
using POSS.Models.Cart;
using POSS.Services.Cart.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSS.Services.Cart.Implementation
{
    public class CartService : ICartService
    {
        private readonly POSSDbContext dbContext;
        public CartService(POSSDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public string AddToCart(CartModel model)
        {
            throw new NotImplementedException();
        }

        public string RemoveFromCart(CartModel model)
        {
            throw new NotImplementedException();
        }

        public string UpdateCart(CartModel model)
        {
            throw new NotImplementedException();
        }

        public List<CartModel> ViewCustomerCart(string Username)
        {
            throw new NotImplementedException();
        }
    }
}
