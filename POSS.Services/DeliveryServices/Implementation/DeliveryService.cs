using Microsoft.EntityFrameworkCore.Metadata.Internal;
using POSS.DataAccess.Context;
using POSS.DataAccess.DataModels;
using POSS.Models.Delivery;
using POSS.Services.DeliveryServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSS.Services.DeliveryServices.Implementation
{
    public class DeliveryService : IDelivery
    {
        private readonly POSSDbContext dbContext;

        public DeliveryService(POSSDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public string AddDeliveryAddress(AddDeliveryAddressModel model)
        {
            try
            {
                using(dbContext)
                {
                    var deliveryAddress = new Delivery
                    {
                        Id = model.Id,
                        City = model.City,
                        Complex = model.Complex,
                        Fullnames = model.Fullnames,
                        isResidential = model.isResidential,
                        PostalCode = model.PostalCode,
                        Province = model.Province,
                        RecipientMobileNo = model.RecipientMobileNo,
                        StreetAddress = model.StreetAddress,
                        Suburb = model.Suburb
                    };
                    dbContext.Add(deliveryAddress);
                    dbContext.SaveChanges();
                    return "Succesfully Added !";
                }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public GetCustomerDeliveryAddressModel GetCustomerDeliveryAddress(int Id)
        {
            using(dbContext)
            {
                return dbContext.Deliveries.Select( z => new GetCustomerDeliveryAddressModel
                {
                    Id = z.Id,
                    City = z.City,
                    Complex = z.Complex,
                    Fullnames = z.Fullnames,
                    isResidential = z.isResidential,
                    PostalCode = z.PostalCode,
                    Province = z.Province,
                    RecipientMobileNo = z.RecipientMobileNo,
                    StreetAddress = z.StreetAddress,
                    Suburb = z.Suburb

                }).Single(x => x.Id == Id);
            }
        }

        public List<GetAllDeliveryAddressesModel> GetAllDeliveryAddresses()
        {
            using(dbContext)
            {
                return dbContext.Deliveries.Select( x => new GetAllDeliveryAddressesModel
                {
                    Id = x.Id,
                    City = x.City,
                    Complex = x.Complex,
                    Fullnames = x.Fullnames,
                    isResidential = x.isResidential,
                    PostalCode = x.PostalCode,
                    Province = x.Province,
                    RecipientMobileNo = x.RecipientMobileNo,
                    StreetAddress = x.StreetAddress,
                    Suburb = x.Suburb

                }).ToList();
            }
        }

        public string RemoveCustomerAddress(int Id)
        {
            try
            {
                using (dbContext)
                {
                    var delivery = dbContext.Deliveries.Find(Id);

                    if (delivery != null)
                    {
                        dbContext.Remove(delivery);
                        dbContext.SaveChanges();
                    }
                    return "Seccusfully Removed !";
                }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
           
        }

        public string UpdateDeliveryAddress(UpdateDeliveryAddressModel model)
        {
            try
            {
                using (dbContext)
                {
                    var delivery = dbContext.Deliveries.Find(model.Id);

                    if (delivery != null)
                    {
                        delivery.City = model.City;
                        delivery.Complex = model.Complex;
                        delivery.Fullnames = model.Fullnames;
                        delivery.isResidential = model.isResidential;
                        delivery.PostalCode = model.PostalCode;
                        delivery.Province = model.Province;
                        delivery.RecipientMobileNo = model.RecipientMobileNo;
                        delivery.StreetAddress = model.StreetAddress;
                        delivery.Suburb = model.Suburb;

                        dbContext.SaveChanges();
                    }
                    return "Seccusfully Removed !";
                }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public bool DeliveryExists(int id)
        {
            using (dbContext)
            {
                var delivery = dbContext.Deliveries.Find(id);

                if (delivery != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
