using Microsoft.AspNetCore.Mvc;

namespace MB.MVC.Controllers
{
    public class BlogController : Controller
    {
        [Route("one-line-a-day")]
        public IActionResult OneLineADay() => View();
    }
}
