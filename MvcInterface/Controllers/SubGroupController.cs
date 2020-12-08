using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MvcInterface.Models;

namespace MvcInterface.Controllers
{
    public class SubGroupController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<SubGroup> reservationList = new List<SubGroup>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/SubGroup"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservationList = JsonConvert.DeserializeObject<List<SubGroup>>(apiResponse);
                }
            }
            return View(reservationList);
        }

    }
}