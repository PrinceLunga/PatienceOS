using POSS.DataAccess.Context;
using POSS.Models.Cart;
using System;
using System.Collections.Generic;
using POSS.DataAccess.DataModels;
using System.Text;
using POSS.Services.CartService.Interface;
using System.Linq;

namespace POSS.Services.CartServices.Implementation
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
            try
            {
                using(dbContext)
                {
                    var cart = new Cart
                    {
                        Id = model.Id,
                        CustomerId = model.CustomerId,
                        DateCreated = DateTime.Now,
                        Discount = model.Discount,
                        NumberOfItems = model.NumberOfItems,
                        Total = model.Total,
                        ProductId = model.ProductId
                     
                    };

                    dbContext.Carts.Add(cart);
                    dbContext.SaveChanges();
                }
                return $"Item {model.Product.Name} added to cart !";
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }

        public string RemoveFromCart(CartModel model)
        {
            try
            {
                using (dbContext)
                {
                    var cart = dbContext.Carts.Find(model.Id);

                    if (cart != null)
                    {
                        dbContext.Carts.Remove(cart);
                        dbContext.SaveChanges();
                    }
                }
                return $"Item {model.Product.Name} removed from cart !";
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
           
        }

        public string UpdateCart(CartModel model)
        {
            throw new NotImplementedException();
        }

        public List<CartModel> ViewCustomerCart(string Username)
        {
            using(dbContext)
            {
                return dbContext.Carts.Where(s => s.Customer.Username == Username).Select(x => new CartModel
                {
                    Id = x.Id,
                    CustomerId = x.CustomerId,
                    Discount = x.Discount,
                    DateCreated = x.DateCreated,
                    NumberOfItems = x.NumberOfItems,
                    ProductId = x.ProductId,
                    Total = x.Total
                }).ToList();
            }
        }
    }
}
