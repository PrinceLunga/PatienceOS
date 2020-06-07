using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using POSS.DataAccess.DataModels;
using POSS.DataAccess.UserModels;
using POSSMvc.Models;

namespace POSSMvc.Controllers
{
    public class CartController : Controller
    {
        private IServiceScopeFactory Services { get; }
      

        public CartController(IServiceScopeFactory _Services)
        {
            Services = _Services;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string ReturnUrl)
        {
            LoginViewModel model = new LoginViewModel
            {
                ReturnUrl = ReturnUrl,
                //ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };
            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string ReturnUrl)
        {
            if(ModelState.IsValid)
            {
                //Do Something
            }
            return View();
        }
        public async Task<IActionResult> AddItemToCartOld(int Id)
        {
            Product cartItem= new Product();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44377/api/Products/GetProduct/" + Id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cartItem = JsonConvert.DeserializeObject<Product>(apiResponse);
                    cartItem.Quantity = 1;
                }
            }
            return View(cartItem);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddItemToCartOld(Product model)
        {
            Product cartModel = new Product();
            using (var httpClient = new HttpClient())
            {
                AddToCartModel _AddToCArtModel = new AddToCartModel
                {
                    Id = model.Id,
                    Username =  this.User.Identity.Name
            };

                StringContent content = new StringContent(JsonConvert.SerializeObject(_AddToCArtModel), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:44377/api/Cart/PostOrder", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                   // cartModel = JsonConvert.DeserializeObject<string>(apiResponse);
                }
            }
            return RedirectToAction(nameof(Indexold));
        }


        public async Task<IActionResult> Indexold()
        {
            List<Product> cartItems = new List<Product>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44377/api/Cart/GetShopppingCartByUser"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cartItems = JsonConvert.DeserializeObject<List<Product>>(apiResponse);
                }
            }
            return View(cartItems);
        }

    }
}