using POSS.Models.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POSS.Services.EmployeeServices
{
    public interface IEmployeeService
    {

        public string AddNewEmployee(AddEmployeeModel model);

        public List<GetAllEmployeesModel> GetAllEmployees();
    }
}
