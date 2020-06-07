using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcInterface.Models
{
    public class TransactionModel
    {
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
