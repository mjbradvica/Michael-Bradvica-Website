namespace MB.MVC.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class BlogController : Controller
    {
        [Route("one-line-a-day")]
        public IActionResult OneLineADay() => View();

        [Route("chain-of-responsibility-adopted-for-dependency-injection")]
        public IActionResult ChainOfResponsibility() => View();

        [Route("purpose-of-the-repository")]
        public IActionResult PurposeOfTheRepository() => View();
    }
}
