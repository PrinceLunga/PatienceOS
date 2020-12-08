using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Unicode;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MvcInterface.Models;

namespace MvcInterface.Controllers
{
    public class ProductController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Product> reservationList = new List<Product>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/Products/GetProducts"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservationList = JsonConvert.DeserializeObject<List<Product>>(apiResponse);
                }
            }
            return View(reservationList);
        }

        public async Task<IActionResult> IndexTest()
        {
            List<Product> reservationList = new List<Product>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/Products/GetProducts"))
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
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/Products/GetProduct/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    product = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return View(product);
        }

        public ViewResult GetProductTest() => View();

        [HttpPost]
        public async Task<IActionResult> GetProductTest(int id)
        {

            Product product = new Product();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/Products/GetProduct/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    product = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return View(product);
        }
        public ViewResult AddProduct() => View();

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductModel product)
        {
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

                //double price = Convert.ToDouble(product.Price);
                var PostProduct = new ProductPost();
                PostProduct.Description = product.Description;
                PostProduct.Group = product.Group;
                PostProduct.Image = Image;
                PostProduct.Name = product.Name;
                PostProduct.Price = product.Price;
                PostProduct.Quantity = product.Quantity;
                PostProduct.Status = product.Status;
                PostProduct.SubGroup = product.SubGroup;
                PostProduct.Vat = 15.00;
                PostProduct.Discount = 0.00;
                PostProduct.DateCreated = DateTime.Now;

                var formDataContent = new MultipartFormDataContent();
                formDataContent.Add(new StringContent(PostProduct.Image), "Image");
                formDataContent.Add(new StringContent(PostProduct.Name), "name");
                formDataContent.Add(new StringContent(PostProduct.Description), "description");
                formDataContent.Add(new StringContent(PostProduct.Group), "group");
                formDataContent.Add(new StringContent(PostProduct.SubGroup), "subGroup");
                formDataContent.Add(new StringContent(PostProduct.Status), "status");
                formDataContent.Add(new StringContent(PostProduct.Price.ToString()), "price");
                formDataContent.Add(new StringContent(PostProduct.Quantity), "quantity");
                formDataContent.Add(new StringContent(PostProduct.Vat.ToString()), "vat");
                formDataContent.Add(new StringContent(PostProduct.Discount.ToString()), "discount");
                formDataContent.Add(new StringContent(PostProduct.DateCreated.ToString()), "datecreated");

                response = await client.PostAsync("https://localhost:44374/api/Products/PostProduct", formDataContent);

                var data = await response.Content.ReadAsStringAsync();
                response.EnsureSuccessStatusCode();
            }
            return RedirectToAction(nameof(Index));
        }

        public ViewResult AddProductTest() => View();

        [HttpPost]
        public async Task<IActionResult> AddProductTest([FromForm] ProductModel product)
        {

            string Url = "https://localhost:44374/api/Products/PostProduct";
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

                //double price = Convert.ToDouble(product.Price);
                var PostProduct = new ProductPost();
                PostProduct.Description = product.Description;
                PostProduct.Group = product.Group;
                PostProduct.Image = Image;
                PostProduct.Name = product.Name;
                PostProduct.Price = product.Price;
                PostProduct.Quantity = product.Quantity;
                PostProduct.Status = product.Status;
                PostProduct.SubGroup = product.SubGroup;
                PostProduct.Vat = 15.00;
                PostProduct.Discount = 0.00;
                PostProduct.DateCreated = DateTime.Now;

                var formDataContent = new MultipartFormDataContent();
                formDataContent.Add(new StringContent(PostProduct.Image), "Image");
                formDataContent.Add(new StringContent(PostProduct.Name), "name");
                formDataContent.Add(new StringContent(PostProduct.Description), "description");
                formDataContent.Add(new StringContent(PostProduct.Group), "group");
                formDataContent.Add(new StringContent(PostProduct.SubGroup), "subGroup");
                formDataContent.Add(new StringContent(PostProduct.Status), "status");
                formDataContent.Add(new StringContent(PostProduct.Price.ToString()), "price");
                formDataContent.Add(new StringContent(PostProduct.Quantity), "quantity");
                formDataContent.Add(new StringContent(PostProduct.Vat.ToString()), "vat");
                formDataContent.Add(new StringContent(PostProduct.Discount.ToString()), "discount");
                formDataContent.Add(new StringContent(PostProduct.DateCreated.ToString()), "datecreated");

                response = await client.PostAsync("https://localhost:44374/api/Products/PostProduct", formDataContent);

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
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/Products/GetProduct/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    product = JsonConvert.DeserializeObject<UpdateProductcs>(apiResponse);
                }
            }
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct([FromForm] UpdateProductcs product)
        {
            using (var httpClient = new HttpClient())
            {
                string serailizedProduct = JsonConvert.SerializeObject(product);

                var inputMessage = new HttpRequestMessage
                {
                    Content = new StringContent(serailizedProduct, Encoding.UTF8, "application/json")
                };

                inputMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage message = httpClient.PutAsync("https://localhost:44374/api/Products/PutProduct", inputMessage.Content).Result;

                if (!message.IsSuccessStatusCode)
                    throw new ArgumentException(message.ToString());

                return RedirectToAction("Index");
            }
        }
    }
}