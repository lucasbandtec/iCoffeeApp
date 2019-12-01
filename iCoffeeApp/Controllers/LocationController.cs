using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace iCoffeeApp.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create()
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateLocation()
        {
            return View();
        }
    }
}