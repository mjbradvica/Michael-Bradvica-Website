using Microsoft.AspNetCore.Mvc;

namespace MB.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
