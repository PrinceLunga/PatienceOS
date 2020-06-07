using POSS.DataAccess.Context;
using POSS.Models.Customer;
using POSS.Services.CustomerServices.Interface;
using System;
using POSS.DataAccess.DataModels;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace POSS.Services.CustomerServices.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly POSSDbContext dbContext;
        public CustomerService(POSSDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public CustomerModel FindCustomer(string Username, string Fullnames, string cellPhone)
        {
            using(dbContext)
            {
                return dbContext.Customers.Where(x => x.Username == Username || x.Fullnames == Fullnames || x.CellNumber == cellPhone )
                    .Select(s => new CustomerModel
                    {
                        Id = s.Id,
                        Fullnames = s.Fullnames,
                        CellNumber = s.CellNumber,
                        Username = s.Username,
                        Address = s.Address,
                        DateOfBirth = s.DateOfBirth,
                        EmailAddress = s.EmailAddress,
                        Password = s.Password

                    }).FirstOrDefault();
            }
        }

        public List<CustomerModel> GetCustomers()
        {
           using(dbContext)
            {
                return dbContext.Customers.Select(x => new CustomerModel
                {
                    Id = x.Id,
                    Fullnames = x.Fullnames,
                    EmailAddress = x.EmailAddress,
                    CellNumber = x.CellNumber,
                    Address = x.Address,
                    Username = x.Username,
                    Password = x.Password
                }).ToList();
            }
        }

        public string RegisterCustomer(CustomerModel model)
        {
            try
            {
                using(dbContext)
                {
                    var customer = new Customer
                    {
                       Id = model.Id,
                       Fullnames = model.Fullnames,
                       Username = model.Username,
                       Address = model.Address,
                       EmailAddress = model.EmailAddress,
                       CellNumber = model.CellNumber,
                       Password = model.Password,
                       DateCreated = DateTime.Now,
                       DateOfBirth = model.DateOfBirth
                    };
                    dbContext.Customers.Add(customer);
                    dbContext.SaveChanges();
                    return $"Customer {model.Fullnames} successfully created !";
                }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public string UpdateProfile(CustomerModel model)
        {
            try
            {
                using (dbContext)
                {
                    var customer = dbContext.Customers.Find(model.Id);

                    if (customer != null)
                    {
                        customer.Id = model.Id;
                        customer.Fullnames = model.Fullnames;
                        customer.EmailAddress = model.EmailAddress;
                        customer.Address = model.Address;
                        customer.CellNumber = model.CellNumber;
                        customer.DateOfBirth = model.DateOfBirth;
                        customer.Password = model.Password;

                        dbContext.SaveChanges();
                       
                    }
                    return $"{model.Fullnames}'s details has been updated successfully !";
                }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
           
        }
    }
}
