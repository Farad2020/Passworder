using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Passworder.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Passworder.Controllers
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
            return View();
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

        [HttpPost]
        public IActionResult Index(string password, int x)
        {
            string realPass = "password123";
            string pass, result = "";


            for (int i = 0; i < 3; i++)
            {
                pass = Console.ReadLine();
                if (pass == realPass)
                {
                    result = "Welcome, User";
                    break;
                }
                x++;
                if (x > 2)
                {
                    result = "Sorry, you're done!";
                    break;
                }
                result = "Incorrect password. You have only " + (3 - x) + " tries";
            }

            ViewBag.result = result;
            ViewBag.x = x;
            return View();
        }
    }
}
