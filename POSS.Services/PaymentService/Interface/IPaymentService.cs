using POSS.Models.Payment;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSS.Services.PaymentService.Interface
{
    public interface IPaymentService
    {
        public string AddPayment(PaymentModel model);

    }
}
