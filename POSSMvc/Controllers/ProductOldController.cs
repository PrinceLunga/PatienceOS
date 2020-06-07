using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Unicode;
using System.Threading;
using System.Threading.Tasks;
using java.lang;
using javax.xml.crypto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using POSSMvc.Models;

namespace POSSMvc.Controllers
{
    public class ProductOldController : Controller
    {
        public async Task<IActionResult> IndexOld()
        {
            List<Product> reservationList = new List<Product>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44377/api/Products/GetProducts"))
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
                using (var response = await httpClient.GetAsync("https://localhost:44377/api/Products/GetProduct/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    product = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return View(product);
        }
        public ViewResult AddProduct() => View();

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromForm] ProductModel product, CancellationToken cancellationToken)
        {
            string Url = "https://localhost:44377/api/Products/PostProduct";
            using (var client = new HttpClient())
            {
                //var a = Object;
                 string Image = "";
                 MultipartFormDataContent multiContent = new MultipartFormDataContent();

                 using (var memoryStream = new MemoryStream())
                 {
                     await product.Image.CopyToAsync(memoryStream);
                     var a = memoryStream.ToArray();
                     Image = Convert.ToBase64String(a);

                 }
                var response = new HttpResponseMessage();

                var PostProduct = new ProductPost
                {
                    Id = product.Id,
                    Description = product.Description,
                    Group = product.Group,
                    Image = Image,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = product.Quantity,
                    Status = product.Status,
                    SubGroup = product.SubGroup,
                    Vat = 15.00
                    
                };

                var formDataContent = new MultipartFormDataContent();
                formDataContent.Add(new StringContent(PostProduct.Image), "image");
                formDataContent.Add(new StringContent(PostProduct.Name), "name");
                formDataContent.Add(new StringContent(PostProduct.Description), "description");
                formDataContent.Add(new StringContent(PostProduct.Group), "group");
                formDataContent.Add(new StringContent(PostProduct.SubGroup), "subGroup");
                formDataContent.Add(new StringContent(PostProduct.Status), "status");
                formDataContent.Add(new StringContent(PostProduct.Price), "price");
                formDataContent.Add(new StringContent(PostProduct.Quantity), "quantity");

                response = await client.PostAsync(Url.ToString(), formDataContent);

                var data = await response.Content.ReadAsStringAsync();
                response.EnsureSuccessStatusCode();
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateProduct(int id)
        {
            UpdateProductcs product = new UpdateProductcs();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44377/api/Products/GetProduct/" + id))
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

                HttpResponseMessage message = httpClient.PutAsync("https://localhost:44377/api/Products/PutProduct", inputMessage.Content).Result;

                if (!message.IsSuccessStatusCode)
                    throw new ArgumentException(message.ToString());

                return RedirectToAction("Index");
            }
        }
    }
}