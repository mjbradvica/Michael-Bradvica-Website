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

        [Route("things-to-remember-with-blazor")]
        public IActionResult ThingsToRememberWithBlazor() => View();

        [Route("minimizing-javascript-interop-in-blazor")]
        public IActionResult MinimizingJavaScriptInteropInBlazor() => View();

        [Route("your-application-is-not-blazor")]
        public IActionResult YourApplicationIsNotBlazor() => View();

        [Route("blazor-hosting-models")]
        public IActionResult BlazorHostingModels() => View();

        [Route("embracing-component-architecture")]
        public IActionResult EmbracingComponentArchitecture() => View();

        [Route("just-because-you-can-does-not-mean-you-should")]
        public IActionResult JustBecauseYouCanDoesNotMeanYouShould() => View();
    }
}
