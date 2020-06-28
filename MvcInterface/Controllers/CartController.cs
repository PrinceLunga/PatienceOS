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
using System.Net.Http.Headers;

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

                    //Update Status
                    item.Status = "Checked-Out";
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

                var customerService = new CustomerService();
                var chargeService = new ChargeService();

                var customer = customerService.Create(new CustomerCreateOptions
                {
                    Email = Email,
                    Source = StripeToken
                });

                var charge = chargeService.Create(new ChargeCreateOptions
                {
                    Amount = Convert.ToInt32(total * 100),
                    Description = "Patience Online Shopping",
                    Currency = "zar",
                    Customer = "cus_HPLfSKAJuEn0yL",
                    
                });

                var options = new SetupIntentCreateOptions
                {
                    Customer = "cus_HPLfSKAJuEn0yL"
                };
                var service = new SetupIntentService();
                var intent = service.Create(options);
                ViewData["ClientSecret"] = intent.ClientSecret;


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
                    TransactionName = "Cheque Out",
                    TriggeredAction = "Payment",
                    EndTime = DateTime.Now.AddSeconds(2),
                    Parameters = $"|Username|{Email}|Discount|{discount}|NoOfItems|{_items}|{DateTime.Now}|Charge|{total}|{vat}"
                };

                StringContent Transactioncontent = new StringContent(JsonConvert.SerializeObject(transaction), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:44374/api/Transaction/LogTransaction", Transactioncontent))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode == true)
                    {
                        //Update Cart Item Status to Checked-Out
                        foreach(var item in cartItems)
                        {
                            
                            string serailizedCartItem = JsonConvert.SerializeObject(item);
                            var inputMessage = new HttpRequestMessage
                            {
                                Content = new StringContent(serailizedCartItem, Encoding.UTF8, "application/json")
                            };

                            inputMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                            HttpResponseMessage message = httpClient.PutAsync("https://localhost:44374/api/Cart/UpdateCartItem", inputMessage.Content).Result;

                            if (!message.IsSuccessStatusCode)
                                throw new ArgumentException(message.ToString());

                            //FInd product to update
                            var productToUpdate = new UpdateProductcs();
                            using (var getProductResponse = await httpClient.GetAsync("https://localhost:44374/api/Products/GetProduct/" + item.Id))
                            {
                                string apiProductResponse = await getProductResponse.Content.ReadAsStringAsync();
                                productToUpdate = JsonConvert.DeserializeObject<UpdateProductcs>(apiProductResponse);
                            }
                            //Update Quantity
                            productToUpdate.Quantity -= item.Quantity;
                            string serailizedProductItem = JsonConvert.SerializeObject(productToUpdate);

                            var inputProductMessage = new HttpRequestMessage
                            {
                                Content = new StringContent(serailizedProductItem, Encoding.UTF8, "application/json")
                            };

                            inputProductMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                            HttpResponseMessage product_message = httpClient.PutAsync("https://localhost:44374/api/Products/PutProduct", inputProductMessage.Content).Result;

                            if (!product_message.IsSuccessStatusCode)
                                throw new ArgumentException(product_message.ToString());

                        }
                    }
                }
            }
            return View();
        }
    }
}