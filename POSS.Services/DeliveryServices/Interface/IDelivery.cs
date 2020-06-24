using POSS.Models.Delivery;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSS.Services.DeliveryServices.Interface
{
    public interface IDelivery
    {
        public string AddDeliveryAddress(AddDeliveryAddressModel model);
        public string UpdateDeliveryAddress(UpdateDeliveryAddressModel model);
        public GetCustomerDeliveryAddressModel GetCustomerDeliveryAddress(int Id);
        public string RemoveCustomerAddress(int Id);
        public List<GetAllDeliveryAddressesModel> GetAllDeliveryAddresses();
        public bool DeliveryExists(int id);
    }
}
