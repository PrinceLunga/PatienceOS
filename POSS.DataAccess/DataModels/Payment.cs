using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POSS.DataAccess.DataModels
{
    public class Payment
    {
        [Key]
        public int Id { get; set;  }
        public string CustomerUsername { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
