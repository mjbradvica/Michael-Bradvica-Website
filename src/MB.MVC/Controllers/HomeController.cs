using System;
using System.Collections.Generic;
using MB.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace MB.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeViewModel _viewModel;

        public HomeController()
        {
            var blogPosts = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("OneLineADay", "One Line A Day"),
            };

            _viewModel = new HomeViewModel(blogPosts);
        }

        [Route("")]
        public IActionResult Index()
        {
            return View(_viewModel);
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }
    }
}
