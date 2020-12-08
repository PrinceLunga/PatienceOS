using POSS.DataAccess.Context;
using POSS.Models.Cart;
using System;
using System.Collections.Generic;
using POSS.DataAccess.DataModels;
using System.Linq;
using POSS.Services.CartServices.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using POSSModels;
using POSS.DataAccess.ProductModels;

namespace POSS.Services.CartServices.Implementation
{
    public class CartService : ICartService
    {
        private readonly POSSDbContext dbContext;

        private Cart cartItem;
        public string UserCartId = null;
        public ServiceProvider service;
        private List<ViewCustomerCartModel> customerProducts = null;
       // public static string ShoppingCartId { get; set; }
       
        public CartService(POSSDbContext _dbContext)
        {
            dbContext = _dbContext;
            cartItem = new Cart();
            customerProducts = new List<ViewCustomerCartModel>();
        }

        //Add a product to a shopping using as Id specified as a parameter
        public CartModel AddToCart(AddToCartModel model)
        {
            try
            {
                using (dbContext)
                {
                    
                    if (model.Username != null)
                    {
                        cartItem = dbContext.Carts.SingleOrDefault(c => c.ProductId == model.Id && c.UserCartId == model.Username && c.Status.Equals("Added"));
                    }

                    //Find the product on the cart
<<<<<<< HEAD
                    //double productPrice = 0;
=======
>>>>>>> origin/sub_Branch

                    var product = dbContext.Products.Where(x => x.Id == model.Id).SingleOrDefault();

                    if (cartItem == null)
                    {
                        // Create a new cart item if no cart item exists.                 
                        cartItem = new Cart
                        {
                            ProductId = model.Id,
                            UserCartId = model.Username,
                            Quantity = 1,
                            Status = "Added",
                            DateCreated = DateTime.Now,
                            Price = product.Price,
                            Discount = 0.00                       
                        };
                        dbContext.Carts.Add(cartItem);
                    }
                    else
                    {
                        // If the item does exist in the cart,                  
                        // then add one to the quantity.                 
                        cartItem.Quantity++;
                        cartItem.Price = product.Price;
                    }
                    dbContext.SaveChanges();

                }
                return new CartModel 
                {
                    ProductId = cartItem.Id,
                    UserCartId = cartItem.UserCartId,
                    Quantity = cartItem.Quantity,
                    DateCreated = cartItem.DateCreated
                };
            }
            catch (Exception ex)
            {

                return new CartModel();
            }
        }

        // Find the Customer ID of the logged on Customer
        public int GetCustomerId(string username)
        {
            using (dbContext)
            {
                return dbContext.Customers.SingleOrDefault( x => x.Username == username).Id;
            }
        }

        //Remove an Item from a Customer's shopping Cart
        public string RemoveFromCart(int Id, string Username)
        {
            try
            {
                using (dbContext)
                {
                    if(Username != null)
                    {
                        var product = dbContext.Products.Find(Id);
                        var cart = dbContext.Carts.Where(x => x.ProductId == Id && x.UserCartId == Username).SingleOrDefault();

                        if (cart != null)
                        {
                            dbContext.Carts.Remove(cart);
                            dbContext.SaveChanges();
                        }

                    }
                }
                return $"Item removed from cart !";
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
           
        }

        // View Customer's shopping using their username
        public List<ViewCustomerCartModel> ViewCustomerCart(string Username)
        {
            using(dbContext)
            {
                double Total = 0;
                var cartItem = dbContext.Carts.Where(s => s.UserCartId == Username && s.Status != "Checked-Out" ).Select(x => new CartModel
                {
                    Id = x.Id,
                    UserCartId = x.UserCartId,
                    Discount = x.Discount,
                    DateCreated = x.DateCreated,
                    Quantity = x.Quantity,
                    ProductId = x.ProductId,
                    Price = x.Price
                }).ToList();

                foreach(var product in cartItem)
                {
                  Total += product.Price * product.Quantity;

                  var productResults = dbContext.Products.Where(c => c.Id == product.ProductId).Select(x => new ViewCustomerCartModel
                  {
                      Id = x.Id,
                      Description = x.Description,
                      Group = x.Group,
                      Image = x.Image,
                      Name = x.Name,
                      Price = x.Price,
                      Quantity = product.Quantity,
                      Status = x.Status,
                      SubGroup = x.SubGroup,
                      Vat = x.Vat,
                      Discount = x.Discount,
                      Total = Total

                  }).SingleOrDefault();

                    customerProducts.Add(productResults);
                }
                return customerProducts.ToList();
            }
        }

        //List all items of a Customer's shopping Cart
        public List<CartModel> GetShoppingCartItems()
        {
            using(dbContext)
            {
                return dbContext.Carts.Where(x => x.UserCartId == UserCartId).Select( x => new CartModel 
                {
                    Id = x.Id,
                    UserCartId = x.UserCartId,
                    ProductId = x.ProductId,
                    DateCreated = x.DateCreated,
                    Quantity = x.Quantity,
                    Discount = x.Discount,
                    Price = x.Price
                }).ToList();
            }
        }

        //Remove all Items from the Customer's shopping Cart
        public void ClearCart()
        {
            using(dbContext)
            {
                var cartItems = dbContext.Carts.Where(x => x.UserCartId == UserCartId);
                dbContext.Carts.RemoveRange(cartItems);
                dbContext.SaveChanges();
            }
        }

        // Get the Total Amount of the Customer Items
        public double GetShoppingCartTotal()
        {
            using(dbContext)
            {
                double total = 0;
                foreach(var cartItem in dbContext.Carts.Where( x => x.UserCartId == UserCartId ))
                {
                    total += dbContext.Products.SingleOrDefault(c => c.Id == cartItem.ProductId).Price;
                }
                return total;
            }
        }


        //Update CartItem Status 
        public void UpdateCartItem(UpdateCartModel model)
        {
            using(dbContext)
            {
                var cartItemForUpdate = dbContext.Carts.Where( x=>x.ProductId == model.Id && x.Status.Equals("Added")).SingleOrDefault();
                cartItemForUpdate.Status = model.Status;
                dbContext.SaveChanges();
            }
        }

        //Check if Cart Item Exists
        public bool CartItemExists(int id)
        {
           using(dbContext)
            {
                var cartItem = dbContext.Carts.Where(x => x.Id == id && x.Status == "Added").SingleOrDefault();
                if (cartItem == null)
                    return false;
                else
                    return true;
            }
        }
    }
}
