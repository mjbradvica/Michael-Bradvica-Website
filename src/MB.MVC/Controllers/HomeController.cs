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
            var blogPosts = new List<string>
            {
                "FixOneLineEveryDay",
            };

            _viewModel = new HomeViewModel(blogPosts);
        }

        public IActionResult Index()
        {
            return View(_viewModel);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
