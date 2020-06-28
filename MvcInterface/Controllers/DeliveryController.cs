using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcInterface.Models;
using Newtonsoft.Json;

namespace MvcInterface.Controllers
{
    public class DeliveryController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<GetAllDeliveryAddressesModel> deliveryList = new List<GetAllDeliveryAddressesModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/Delivery/GetAllDeliveries"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    deliveryList = JsonConvert.DeserializeObject<List<GetAllDeliveryAddressesModel>>(apiResponse);
                }
            }
            return View(deliveryList);
        }

        public ViewResult AddDeliveryAddress() => View();

        [HttpPost]
        public async Task<IActionResult> AddDeliveryAddress(AddDeliveryAddressModel model)
        {
            AddDeliveryAddressModel receivedDeliveryAddress = new AddDeliveryAddressModel();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:44374/api/Delivery/PostDelivery", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedDeliveryAddress = JsonConvert.DeserializeObject<AddDeliveryAddressModel>(apiResponse);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> GetCustomerDeliveryAddress(int id)
        {
            GetCustomerDeliveryAddressModel deliveryAddress = new GetCustomerDeliveryAddressModel();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/Delivery/GetCustomerDelivery/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    deliveryAddress = JsonConvert.DeserializeObject<GetCustomerDeliveryAddressModel>(apiResponse);
                }
            }
            return View(deliveryAddress);
        }


        public async Task<IActionResult> UpdateDeliveryAddress(int id)
        {
            UpdateDeliveryAddressModel deliveryAddress = new UpdateDeliveryAddressModel();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/Delivery/GetCustomerDelivery/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    deliveryAddress = JsonConvert.DeserializeObject<UpdateDeliveryAddressModel>(apiResponse);
                }
            }
            return View(deliveryAddress);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateDeliveryAddress(UpdateDeliveryAddressModel model)
        {
            using (var httpClient = new HttpClient())
            {
                string serailizedProduct = JsonConvert.SerializeObject(model);

                var inputMessage = new HttpRequestMessage
                {
                    Content = new StringContent(serailizedProduct, Encoding.UTF8, "application/json")
                };

                inputMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage message = httpClient.PutAsync("https://localhost:44374/api/Delivery/PutDelivery", inputMessage.Content).Result;

                if (!message.IsSuccessStatusCode)
                    throw new ArgumentException(message.ToString());

                return RedirectToAction("Index");
            }
        }
    }
}
