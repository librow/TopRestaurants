using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TopRestaurants.Models;

namespace TopRestaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> RestaurantList = new List<string>();   //creating a list variable

            foreach(Restaurant r in Restaurant.GetRestaurants())    //loops through each restaurant object and creates a string of the features
            {
                RestaurantList.Add($"#{r.RestRank}: {r.RestName}, {r.FavDish}, {r.Address}, {r.PhoneNum}, {r.Website}");
            }

            return View(RestaurantList);
        }

        [HttpGet]
        public IActionResult Suggestions()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Suggestions(Suggestion suggestion)
        {
            if (ModelState.IsValid) //checks if the form input is valid and then executes statement inside if
            {
                TempStorage.AddRestaurant(suggestion);
                Response.Redirect("Suggestions");
            }
            return View("Suggestions");            
        }

        public IActionResult SuggestionList()
        {
            return View(TempStorage.Suggestion);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
