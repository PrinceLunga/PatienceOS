using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POSS.Models.Transaction;
using POSS.Services.TransactionService.Interface;

namespace POSS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService transactionService;

        public TransactionController(ITransactionService _transactionService)
        {
            transactionService = _transactionService;
        }

        public ActionResult<TransactionModel> LogTransaction(TransactionModel model)
        {
            if (model != null)
            {
                transactionService.LogTransaction(model);
                return model;
            }
            else
                return null;
        }
    }
}
