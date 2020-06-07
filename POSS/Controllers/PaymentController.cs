using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POSS.Models.Payment;
using POSS.Services.PaymentService.Interface;

namespace POSS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService paymentService;
        public PaymentController(IPaymentService _paymentService)
        {
            paymentService = _paymentService;
        }

        public ActionResult<PaymentModel> AddPayment(PaymentModel model)
        {
            if (model != null)
            {
                paymentService.AddPayment(model);
                return model;
            }
            else
                return null;
        }

    }
}
