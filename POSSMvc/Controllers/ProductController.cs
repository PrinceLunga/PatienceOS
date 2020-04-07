using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using java.lang;
using javax.xml.crypto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using POSSMvc.Models;

namespace POSSMvc.Controllers
{
    public class ProductController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Product> reservationList = new List<Product>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/Products"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservationList = JsonConvert.DeserializeObject<List<Product>>(apiResponse);
                }
            }
            return View(reservationList);
        }

        public ViewResult GetProduct() => View();

        [HttpPost]
        public async Task<IActionResult> GetProduct(int id)
        {
            Product product = new Product();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/Products/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    product = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return View(product);
        }

        public ViewResult AddProduct() => View();

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            Product receivedProduct = new Product();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44374/api/Products", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedProduct = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return View(receivedProduct);
        }
        public async Task<IActionResult> UpdateProduct(int id)
        {
            UpdateProductcs product = new UpdateProductcs();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/Products/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    product = JsonConvert.DeserializeObject<UpdateProductcs>(apiResponse);
                }
            }
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductcs product)
        {
            using (var httpClient = new HttpClient())
            {
                string serailizedProduct = JsonConvert.SerializeObject(product);

                var inputMessage = new HttpRequestMessage
                {
                    Content = new StringContent(serailizedProduct, Encoding.UTF8, "application/json")
                };

                inputMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage message = httpClient.PutAsync("https://localhost:44374/api/Products", inputMessage.Content).Result;

                if (!message.IsSuccessStatusCode)
                    throw new ArgumentException(message.ToString());

                return RedirectToAction("Index");
            }
        }
    }
}