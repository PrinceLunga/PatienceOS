using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POSS.Models.Employee
{
    public class AddEmployeeModel
    {
        [Key]
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Role { get; set; }
        public string CellNumber { get; set; }
    }
}
