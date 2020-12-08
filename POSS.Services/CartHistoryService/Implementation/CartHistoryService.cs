using Microsoft.Extensions.DependencyInjection;
using POSS.DataAccess.Context;
using POSS.DataAccess.DataModels;
using POSS.Models.CartHistory;
using POSS.Services.CartHistoryService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSS.Services.CartHistoryService
{
    public class CartHistoryService : ICartHistoryService
    {
        private readonly POSSDbContext dbContext;
        private CartHistoryModel cartItem;
        public string UserCartId = null;
        public ServiceProvider service;

        public CartHistoryService(POSSDbContext context)
        {
            dbContext = context;
        }


        public CartHistoryModel AddToCartHistory(CartHistoryModel model)
        {
            using (dbContext)
            {
                if (model != null)
                {
                    CartHistory history = new CartHistory
                    {
                        CartHistoryId = model.CartHistoryId,
                        ProductId = model.ProductId,
                        UserCartId = model.UserCartId,
                        //Product = model.Product,
                        Quantity = model.Quantity,
                        Price =model.Price,
                        Status = model.Status,
                        DateRecorded = model.DateRecorded
                    };
                    _ = dbContext.CartHistories.Add(history);
                    _ = dbContext.SaveChanges();
                    return model;
                }
            }
            return model;
        }

        public List<CartHistoryModel> ViewCartHistory()
        {
            using (dbContext)
            {
                return dbContext.CartHistories.Select(x => new CartHistoryModel
                {
                    CartHistoryId = x.CartHistoryId,
                    //Product = x.Product,
                    DateRecorded = x.DateRecorded,
                    Quantity = x.Quantity,
                    UserCartId = x.UserCartId,
                    Price = x.Price,
                    ProductId = x.ProductId,
                    Status = x.Status
                }).ToList();
            }
        }

        public CartHistoryModel UpdateCartHistory(int modelCartHistoryId, CartHistoryModel model)
        {
            throw new NotImplementedException();
        }

        public string DeleteCartHistory(int modelCartHistoryId)
        {
            throw new NotImplementedException();
        }
    }
}
