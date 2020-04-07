using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using POSSMvc.Models;
using Group = POSSMvc.Models.Group;

namespace POSSMvc.Controllers
{
    public class GroupController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Group> reservationList = new List<Group>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44374/api/Group"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservationList = JsonConvert.DeserializeObject<List<Group>>(apiResponse);
                }
            }
            return View(reservationList);
        }
    }
}