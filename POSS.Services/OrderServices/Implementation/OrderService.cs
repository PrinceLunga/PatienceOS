using POSS.DataAccess.Context;
using POSS.DataAccess.DataModels;
using POSS.DataAccess.ProductModels;
using POSS.Models.Cart;
using POSS.Models.Order;
using POSS.Services.OrderServices.Interface;
using POSS.Services.CartServices.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSSModels;

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
                        order.CartUserId = model.CartUserId;
                        order.OrderDate = model.OrderDate;
                        order.Status = "Delivered";
                        order.CompletionDate = model.CompletionDate;
                        
                    }

                    dbContext.SaveChanges();
                }
                return $"Order has been delivered succesfully !";
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }
        public string CreateOrder( List<ProductModel> model, string username)
        {
            double Total = 0;
            ProductModel localModel = null;
            double Discount = 0D;
            string CartResults = "";
            int numberOfItems = 0;
            try
            {
                using(dbContext)
                {
                    numberOfItems = model.Count;
                    int CustomerId = dbContext.Customers.Where(x => x.Username == username).SingleOrDefault().Id;
                    foreach (var item in model)
                    {
                        localModel = item;
                        Total += item.Price;
                        Discount += item.Discount;
                    }
                    var order = new Order
                    {
                        Status = "Created",
                        OrderDate = DateTime.Now,
                        Discount = Discount,
                        Total = Total,
                        VAT = localModel.Vat,
                        Items = numberOfItems
                     };


                    //Proceed and Save a new Order
                    if (CartResults.Contains("Item"))
                    {
                        dbContext.Orders.Add(order);
                        dbContext.SaveChanges();
                    }


                }
                return $"Order successfully created !";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public OrderModel CreateOrder(OrderModel model)
        { 
            try
            {
                using (dbContext)
                {
                    if (model != null)
                    {
                        var order = new Order
                        {
                            Id = model.Id,
                            Status = "Created",
                            Discount = model.Discount,
                            Items = model.Items,
                            OrderDate = DateTime.Now,
                            Total = model.Total,
                            VAT = model.VAT,
                            CartUserId = model.CartUserId
                        };

                        dbContext.Add(order);
                        dbContext.SaveChanges();
                        return model;
                    }
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {

                throw new Exception();
            }
           
        }

        public OrderModel FindOrder(OrderModel model)
        {
            using(dbContext)
            {
                return dbContext.Orders.Where(x => x.Id == model.Id || x.CartUserId == model.CartUserId)
                    .Select( z => new OrderModel 
                    { 
                        Id = z.Id,
                        Status = z.Status,
                        OrderDate = z.OrderDate,
                        CompletionDate = z.CompletionDate,
                        CartUserId = z.CartUserId,
                        VAT = z.VAT,
                        Total = z.Total,
                        Items = z.Items,
                        Discount = z.Discount

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
                    CartUserId = x.CartUserId,
                    OrderDate = x.OrderDate,
                    Status = x.Status,
                    Items = x.Items,
                    Discount = x.Discount,
                    Total = x.Total,
                    VAT = x.VAT

                }).ToList();
            }
        }

        public string SendInvoice(string Username, int OrderId)
        {
            throw new NotImplementedException();
        }

        public string SetShippingAddress(string Username)
        {
            throw new NotImplementedException();
        }

        public string SetWrappingOptions()
        {
            throw new NotImplementedException();
        }

        public string UpdateOrder(OrderModel model)
        {
            try
            {
                using (dbContext)
                {
                    var order = dbContext.Orders.Where(x =>  x.CartUserId == model.CartUserId).SingleOrDefault();

                    if (order != null)
                    {
                        order.Id = model.Id;
                        order.OrderDate = model.OrderDate;
                        order.Status = model.Status;

                        dbContext.SaveChanges();
                    }
                    return $"Order  has been updated succesfully !";
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
            
        }
    }
}
