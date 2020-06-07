using POSS.Models.Transaction;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSS.Services.TransactionService.Interface
{
    public interface ITransactionService
    {
        public string LogTransaction(TransactionModel model);
    }
}
