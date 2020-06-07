using POSS.DataAccess.Context;
using POSS.DataAccess.DataModels;
using POSS.Models.Transaction;
using POSS.Services.TransactionService.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSS.Services.TransactionService.Implementation
{
    public class TransactionService : ITransactionService
    {
        private readonly POSSDbContext dbContext;

        public TransactionService(POSSDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public string LogTransaction(TransactionModel model)
        {
            try
            {
                using (dbContext)
                {
                    var transaction = new Transaction
                    {
                        EndTime = model.EndTime,
                        Status = model.Status,
                        TransactionName = model.TransactionName,
                        StartTime = model.StartTime,
                        Failure = model.Failure,
                        Parameters = model.Parameters,
                        Success = model.Success,
                        TriggeredAction = model.TriggeredAction
                    };
                    dbContext.Add(transaction);
                    dbContext.SaveChanges();
                    return "Logged Transaction successfully completed";
                }
            }
            catch (Exception ex)
            {

                return ex.InnerException.Message;
            }
        }
    }
}
