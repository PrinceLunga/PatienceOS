using Microsoft.AspNetCore.Mvc;
using MvcInterface.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MvcInterface.Controllers
{
    public class CartHistoryController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> ViewCartHistory()
        {
            List<CartHistoryModel> cartHistoryList = new List<CartHistoryModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/CartHistory/ViewCartHistory"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cartHistoryList = JsonConvert.DeserializeObject<List<CartHistoryModel>>(apiResponse);
                }
            }
            return View(cartHistoryList);
        }


        public ViewResult AddToCartHistory() => View();

        [HttpPost]
        public async Task<IActionResult> AddToCartHistory(CartHistoryModel cartHistoryModel)
        {
            CartHistoryModel receivedHistory = new CartHistoryModel();
            using (var httpClient = new HttpClient())
            {
                StringContent stringContent = new StringContent(JsonConvert.SerializeObject(cartHistoryModel), Encoding.UTF8, "Application/json");
                using (var response = await httpClient.PostAsync("https://localhost:44374/api/CartHistory/AddToCartHistory", stringContent))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedHistory = JsonConvert.DeserializeObject<CartHistoryModel>(apiResponse);
                }
            }
            return RedirectToAction(nameof(ViewCartHistory));
        }

        public async Task<IActionResult> UpdateCartHistory(int id)
        {
            CartHistoryModel cartHistoty = new CartHistoryModel();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/CartHistory/GetHistoryById/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cartHistoty = JsonConvert.DeserializeObject<CartHistoryModel>(apiResponse);
                }
            }
            return View(cartHistoty);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCartHistory(CartHistoryModel cartHistory)
        {
            using (var httpClient = new HttpClient())
            {
                string serailizedProduct = JsonConvert.SerializeObject(cartHistory);

                var inputMessage = new HttpRequestMessage
                {
                    Content = new StringContent(serailizedProduct, Encoding.UTF8, "application/json")
                };

                inputMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage message = httpClient.PutAsync("https://localhost:44374/api/CartHistory/UpdateCartHistory", inputMessage.Content).Result;

                if (!message.IsSuccessStatusCode)
                    throw new ArgumentException(message.ToString());

                return RedirectToAction(nameof(ViewCartHistory));
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> DeleteCartHistory(int id)
        {
            CartHistoryModel cartHistoty = new CartHistoryModel();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/CartHistory/GetHistoryById/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cartHistoty = JsonConvert.DeserializeObject<CartHistoryModel>(apiResponse);

                    StringContent content = new StringContent(JsonConvert.SerializeObject(cartHistoty), Encoding.UTF8, "application/json");

                    var _response = await httpClient.PostAsync("https://localhost:44374/api/CartHistory/RemoveCartHistory/", content);
                    string _apiResponse = await response.Content.ReadAsStringAsync();
                    cartHistoty = JsonConvert.DeserializeObject<CartHistoryModel>(_apiResponse);
                }
            }
            return View(cartHistoty);
        }
    }

}

