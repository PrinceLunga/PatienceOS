using Microsoft.AspNetCore.Mvc;
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


        public string AddToCartHistory(CartHistoryModel model)
        {
            using (dbContext)
            {
                if (model != null)
                {
                    CartHistory history = new CartHistory
                    {
                        ProductId = model.ProductId,
                        UserCartId = model.UserCartId,
                        Quantity = model.Quantity,
                        Price =model.Price,
                        Status = model.Status,
                        DateRecorded = model.DateRecorded
                    };
                    _ = dbContext.CartHistories.Add(history);
                    _ = dbContext.SaveChanges();
                    return "Successfully added !";
                }
            }
            return null;
        }

        public List<CartHistoryModel> ViewCartHistory()
        {
            using (dbContext)
            {
                return dbContext.CartHistories.Select(x => new CartHistoryModel
                {
                    CartHistoryId = x.CartHistoryId,
                    DateRecorded = x.DateRecorded,
                    Quantity = x.Quantity,
                    UserCartId = x.UserCartId,
                    Price = x.Price,
                    ProductId = x.ProductId,
                    Status = x.Status
                }).ToList();
            }
        }

        public string UpdateCartHistory(CartHistoryModel model)
        {
            try
            {
                using (dbContext)
                {
                    var history = dbContext.CartHistories.Find(model.CartHistoryId);

                    history.UserCartId = model.UserCartId;
                    history.Status = model.Status;
                    history.ProductId = model.ProductId;
                    history.Price = model.Price;
                    history.Quantity = model.Quantity;
                    history.DateRecorded = model.DateRecorded;

                    dbContext.SaveChanges();
                    return "Successfully updated!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public string DeleteCartHistory(CartHistoryModel modelCartHistoryId)
        {
            try
            {
                using (dbContext)
                {
                    var history = dbContext.CartHistories.Find(modelCartHistoryId.CartHistoryId);
                    dbContext.Remove(history);
                    dbContext.SaveChanges();
                    return "Successfully updated!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public CartHistoryModel FindHistoryById(int id)
        {
            using (dbContext)
            {
                return dbContext.CartHistories.Select(x => new CartHistoryModel
                {
                    CartHistoryId = x.CartHistoryId,
                    DateRecorded = x.DateRecorded,
                    Price = x.Price,
                    ProductId = x.ProductId,
                    Quantity = x.Quantity,
                    Status = x.Status,
                    UserCartId = x.UserCartId
                }).FirstOrDefault(b => b.CartHistoryId == id);
            }
        }
    }
}
