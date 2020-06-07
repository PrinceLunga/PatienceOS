using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POSS.DataAccess.DataModels
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public string TransactionName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status { get; set; }
        public string TriggeredAction { get; set; }
        public bool Success { get; set; }
        public bool Failure { get; set; }
        public string Parameters { get; set; }

    }
}
