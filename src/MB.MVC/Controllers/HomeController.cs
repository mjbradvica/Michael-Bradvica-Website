namespace MB.MVC.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models;

    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View(BlogPosts.AllPosts());
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }
    }
}
