using POSS.DataAccess.Context;
using POSS.DataAccess.DataModels;
using POSS.Models.Cart;
using POSS.Models.Order;
using POSS.Services.OrderServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSS.Services.OrderServices.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly POSSDbContext dbContext;
        public OrderService(POSSDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public string CompleteOrder(OrderModel model)
        {
            try
            {
                using (dbContext)
                {
                    var order = dbContext.Orders.Find(model.Id);
                        
                   if(order != null)
                   {
                        order.Id = model.Id;
                        order.Number = model.Number;
                        order.Description = model.Description;
                        order.Status = model.Status;
                        order.OrderDate = model.OrderDate;
                        order.CompletionDate = DateTime.Now;
                        order.CustomerId = model.CustomerId;
                        order.CartId = model.CartId;

                    }

                    dbContext.SaveChanges();
                }
                return $"Order {model.Number} has been completed succesfully !";
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }
        public string CreateOrder(OrderModel model, string username)
        {
            try
            {
                using(dbContext)
                {
                    int CustomerId = dbContext.Customers.Where(x => x.Username == username).SingleOrDefault().Id;
                    var order = new Order
                    {
                        Id = model.Id,
                        Status = model.Status,
                        Number = model.Number,
                        Description = model.Description,
                        CustomerId = CustomerId,
                        OrderDate = DateTime.Now,
                        CartId = model.CartId
                    };
                    dbContext.Orders.Add(order);
                    dbContext.SaveChanges();
                }
                return $"Order for {model.Customer.Fullnames} successfully created !";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public OrderModel FindOrder(OrderModel model)
        {
            using(dbContext)
            {
                return dbContext.Orders.Where(x => x.Id == model.Id || x.CustomerId == model.CustomerId)
                    .Select( z => new OrderModel 
                    { 
                        Id = z.Id,
                        Description = z.Description,
                        CustomerId = z.CustomerId,
                        Number = z.Number,
                        Status = z.Status,
                        OrderDate = z.OrderDate,
                        CompletionDate = z.CompletionDate,
                        CartId = z.CartId
                    }).SingleOrDefault();
            }
        }

        public List<OrderModel> GetOrder()
        {
           using(dbContext)
            {
                return dbContext.Orders.Select(x => new OrderModel
                {
                    Id = x.Id,
                    CartId = x.CartId,
                    CustomerId = x.CustomerId,
                    Description = x.Description,
                    Number = x.Number,
                    OrderDate = x.OrderDate,
                    Status = x.Status,
                    Type = x.Type
                }).ToList();
            }
        }

        public string UpdateOrder(OrderModel model)
        {
            try
            {
                using (dbContext)
                {
                    var order = dbContext.Orders.Where(x => x.Number == model.Number || x.CustomerId == model.CustomerId).SingleOrDefault();

                    if (order != null)
                    {
                        order.Id = model.Id;
                        order.Number = model.Number;
                        order.OrderDate = model.OrderDate;
                        order.Status = model.Status;
                        order.Description = model.Description;

                        dbContext.SaveChanges();
                    }
                    return $"Order {order.Number} has been updated succesfully !";
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
            
        }
    }
}
