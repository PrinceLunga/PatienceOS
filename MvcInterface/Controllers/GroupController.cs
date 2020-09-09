using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MvcInterface.Models;


namespace MvcInterface.Controllers
{
    public class GroupController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Group> reservationList = new List<Group>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(" https://localhost:44374/api/Group/GetGroups"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservationList = JsonConvert.DeserializeObject<List<Group>>(apiResponse);
                }
            }
            return View(reservationList);
        }

        public ViewResult AddGroup() => View();

        [HttpPost]
        public async Task<IActionResult> AddGroup(Group group)
        {
            Group receivedGroup = new Group();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(group), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:44374/api/Group/PostGroup", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedGroup = JsonConvert.DeserializeObject<Group>(apiResponse);
                }
            }
            return RedirectToAction(nameof(Index));
        }
        
        public async Task<IActionResult> UpdateGroup(int id)
        {
            Group group = new Group();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/Group/GetGroup/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    group = JsonConvert.DeserializeObject<Group>(apiResponse);
                }
            }
            return View(group);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateGroup(Group group)
        {
            using (var httpClient = new HttpClient())
            {
                string serailizedProduct = JsonConvert.SerializeObject(group);

                var inputMessage = new HttpRequestMessage
                {
                    Content = new StringContent(serailizedProduct, Encoding.UTF8, "application/json")
                };

                inputMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage message = httpClient.PutAsync("https://localhost:44374/api/Group/PutGroup", inputMessage.Content).Result;

                if (!message.IsSuccessStatusCode)
                    throw new ArgumentException(message.ToString());

                return RedirectToAction("Index");
            }
        }



        public async Task<IActionResult> DeleteGroup(int id)
        {
            Group group = new Group();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/Group/DeleteGroup/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    group = JsonConvert.DeserializeObject<Group>(apiResponse);
                }
            }
            return View(group);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteGroup(Group group)
        {
            using (var httpClient = new HttpClient())
            {
                string serailizedProduct = JsonConvert.SerializeObject(group);

                var inputMessage = new HttpRequestMessage
                {
                    Content = new StringContent(serailizedProduct, Encoding.UTF8, "application/json")
                };

                inputMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage message = httpClient.DeleteAsync("https://localhost:44374/api/Group/DeleteGroup" + group.Id).Result;

                if (!message.IsSuccessStatusCode)
                    throw new ArgumentException(message.ToString());

                return RedirectToAction("Index");
            }
        }
    }
}