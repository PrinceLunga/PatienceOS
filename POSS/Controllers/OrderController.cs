using Microsoft.AspNetCore.Mvc;
using POSS.Models.Order;
using POSS.Services.OrderServices.Interface;

namespace POSS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService _orderService)
        {
            orderService = _orderService;
        }

        [HttpPost]
        public ActionResult<OrderModel> CreateOrder(OrderModel orderModel)
        {
            if (orderModel != null)
            {
                var order = new OrderModel
                {
                    Items = orderModel.Items,
                    CartUserId = orderModel.CartUserId,
                    Discount = orderModel.Discount,
                    OrderDate = orderModel.OrderDate,
                    Status = orderModel.Status,
                    Total = orderModel.Total,
                    VAT = orderModel.VAT,

                };
                orderService.CreateOrder(order);
                return order;
            }
            else
                return null;
        }
    }
}
