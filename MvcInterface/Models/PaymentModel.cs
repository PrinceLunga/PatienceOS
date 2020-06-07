using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcInterface.Models
{
    public class PaymentModel
    {
        public int Id { get; set; }
        public string CustomerUsername { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
