namespace MB.MVC.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class BlogController : Controller
    {
        [Route("one-line-a-day")]
        public IActionResult OneLineADay() => View();

        [Route("chain-of-responsibility-adopted-for-dependency-injection")]
        public IActionResult ChainOfResponsibilityForDependencyInjection() => View();

        [Route("the-purpose-of-the-repository-pattern")]
        public IActionResult PurposeOfTheRepositoryPattern() => View();
    }
}
