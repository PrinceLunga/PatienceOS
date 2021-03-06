﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POSS.DataAccess.DataModels
{
    public class Delivery
    {
        [Key]
        public int Id { get; set; }
        public string Fullnames { get; set; }
        public string RecipientMobileNo { get; set; }
        public string StreetAddress { get; set; }
        public string Complex { get; set; }
        public bool isResidential { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
    }
}
