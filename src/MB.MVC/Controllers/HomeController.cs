using System;
using System.Collections.Generic;
using MB.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace MB.MVC.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }
    }
}
