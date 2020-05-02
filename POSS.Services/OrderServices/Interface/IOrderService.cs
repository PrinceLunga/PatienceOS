using POSS.Models.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSS.Services.OrderServices.Interface
{
    public interface IOrderService
    {
        public string CreateOrder(OrderModel model, string username);
        public string UpdateOrder(OrderModel model);
        public OrderModel FindOrder(OrderModel model);
        public string CompleteOrder(OrderModel model);
        public List<OrderModel> GetOrder();
    }
}
