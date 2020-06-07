using POSS.Models.Order;
using POSSModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSS.Services.OrderServices.Interface
{
    public interface IOrderService
    {
        public OrderModel CreateOrder(OrderModel model);
        public string UpdateOrder(OrderModel model);
        public OrderModel FindOrder(OrderModel model);
        public string CompleteOrder(OrderModel model);
        public List<OrderModel> GetOrder();
        public string SendInvoice(string Username, int OrderId);
        public string SetShippingAddress(string Username);
        public string SetWrappingOptions();
    }
}
