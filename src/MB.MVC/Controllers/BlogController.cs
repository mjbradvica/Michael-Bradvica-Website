using Microsoft.AspNetCore.Mvc;

namespace MB.MVC.Controllers
{
    public class BlogController : Controller
    {
        [Route("One-Line-A-Day")]
        public IActionResult OneLineADay()
        {
            return View();
        }
    }
}
