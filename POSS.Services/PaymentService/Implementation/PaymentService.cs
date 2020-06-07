using POSS.DataAccess.Context;
using POSS.DataAccess.DataModels;
using POSS.Models.Payment;
using POSS.Services.PaymentService.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSS.Services.PaymentService.Implementation
{
    public class PaymentService : IPaymentService
    {
        private readonly POSSDbContext dbContext;

        public PaymentService(POSSDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public string AddPayment(PaymentModel model)
        {
            try
            {
                using (dbContext)
                {
                    var payment = new Payment
                    {
                        Id = model.Id,
                        Amount = model.Amount,
                        CustomerUsername = model.CustomerUsername,
                        PaymentDate = DateTime.Now
                    };

                    dbContext.Add(payment);
                    dbContext.SaveChanges();
                    return "Successfully added payment transaction";
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
           
        }
    }
}
