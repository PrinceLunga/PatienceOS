using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using MvcInterface.Models;
using Stripe;
using Product = MvcInterface.Models.Product;
using POSS.Models.Order;
using System;
using POSS.DataAccess.DataModels;

namespace MvcInterface.Controllers
{
  
    public class CartController : Controller
    {
        private IServiceScopeFactory Services { get; }
        private string Username = null;
      

        public CartController(IServiceScopeFactory _Services)
        {
            Services = _Services;
        }

        [HttpGet]
        public async Task<IActionResult> AddItemToCart(int Id)
        {
            List<Product> products = new List<Product>();
            Product cartItem= new Product();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/Products/GetProduct/" + Id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cartItem = JsonConvert.DeserializeObject<Product>(apiResponse);
                    cartItem.Quantity = 1;
                }
            }
            products.Add(cartItem);
            return View(products);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddItemToCart(Product model)
        {
            Product cartModel = new Product();
            using (var httpClient = new HttpClient())
            {
                AddToCartModel _AddToCArtModel = new AddToCartModel
                {
                    Id = model.Id,
                    Username =  this.User.Identity.Name
                };
                Username = _AddToCArtModel.Username;
                StringContent content = new StringContent(JsonConvert.SerializeObject(_AddToCArtModel), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:44374/api/Cart/PostOrder", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                   // cartModel = JsonConvert.DeserializeObject<string>(apiResponse);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Product> cartItems = new List<Product>();
            using (var httpClient = new HttpClient())
            {
                Username = this.User.Identity.Name;
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/Cart/GetShoppingCartByUser/"+ Username))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cartItems = JsonConvert.DeserializeObject<List<Product>>(apiResponse);
                }
            }
            return View(cartItems);
        }

        public async Task<IActionResult> RemoveCartItem(int id)
        {
            Product product = new Product();
            using (var httpClient = new HttpClient())
            {
                AddToCartModel _AddToCArtModel = new AddToCartModel
                {
                    Id = id,
                    Username = this.User.Identity.Name
                };
                Username = _AddToCArtModel.Username;
                StringContent content = new StringContent(JsonConvert.SerializeObject(_AddToCArtModel), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:44374/api/Cart/RemoveCartItem", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        public async Task<IActionResult> Charge( string StripeToken)
        {
            StripeConfiguration.ApiKey = "sk_test_99sMl215aPWJseNI5pS0T7D200pYyI9Kvc";
            string Email;
            int _items = 0;
            double total = 0;
            double discount = 0;
            double vat = 0;
            var order = new OrderModel();
            Email = this.User.Identity.Name;


            var customerService = new CustomerService();
            var chargeService = new ChargeService();

            var customer = customerService.Create(new CustomerCreateOptions
            {
                Email = Email,
                Source = StripeToken
            });

            var charge = chargeService.Create(new ChargeCreateOptions
            {
                Amount = 500,
                Description = "Patience Online Shopping",
                Currency = "USD",
                Customer = "cus_HPLfSKAJuEn0yL"
            });

            var options = new SetupIntentCreateOptions
            {
                Customer = "cus_HPLfSKAJuEn0yL"
            };
            var service = new SetupIntentService();
            var intent = service.Create(options);
            ViewData["ClientSecret"] = intent.ClientSecret;


            List<Product> cartItems = new List<Product>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/Cart/GetShoppingCartByUser/" + Email))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cartItems = JsonConvert.DeserializeObject<List<Product>>(apiResponse);
                }
           
                int counter = 0;
                foreach(var item in cartItems)
                {
                    counter++;
                

                    _items = cartItems.Count;
                    total += item.Price * item.Quantity;
                    discount += item.Discount;
                   

                    if (counter == cartItems.Count)
                    {
                        vat = total * 0.15;
                        order = new OrderModel
                        {
                            Items = _items,
                            Status = "Created",
                            Discount = 0.00,
                            Total = total,
                            VAT = 15,
                            OrderDate = DateTime.Now,
                            CartUserId = this.User.Identity.Name,
                            CompletionDate = new DateTime(),
                            Id = 1

                        };

                    }

                }


                //Call create Order
                StringContent Ordercontent = new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:44374/api/Order/CreateOrder", Ordercontent))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }

                //Call insert into Payment Transaction

                var payment = new PaymentModel
                {
                    CustomerUsername = Email,
                    Amount = total,
                    PaymentDate = DateTime.Now
                
                };

                StringContent content = new StringContent(JsonConvert.SerializeObject(payment), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:44374/api/Payment/AddPayment", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }

               
                //Call insert into Transactions
                var transaction = new TransactionModel
                {
                    Status = "Success",
                    StartTime = DateTime.Now.AddSeconds(1),
                    Success = true,
                    Failure = false,
                    TransactionName = "Charge",
                    TriggeredAction = "Charge",
                    EndTime = DateTime.Now.AddSeconds(2),
                    Parameters = $"{Email}|{discount}|{_items}|{DateTime.Now}|Charge|{total}|{vat}"
                };

                StringContent Transactioncontent = new StringContent(JsonConvert.SerializeObject(transaction), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:44374/api/Transaction/LogTransaction", Transactioncontent))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }

            }

            return View(charge);
        }


    }
}