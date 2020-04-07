using System;
using System.Collections.Generic;
using System.Text;

namespace POSS.DataAccess.EmployeeModels
{
    public class Employee
    {
        public int Id { get; set; }
        public string Fulllnames { get; set; }
        public string EmailAddress { get; set; }
        public string CellNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool isAdmin { get; set; }

    }
}
