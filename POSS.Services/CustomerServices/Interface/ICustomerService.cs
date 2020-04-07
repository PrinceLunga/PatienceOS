using POSS.Models.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSS.Services.CustomerServices.Interface
{
    public interface ICustomerService
    {
        public string RegisterCustomer(CustomerModel model);
        public string UpdateProfile(CustomerModel model);
        public CustomerModel FindCustomer(string Username, string Fullnames, string cellPhone);
        public List<CustomerModel> GetCustomers();


    }
}
