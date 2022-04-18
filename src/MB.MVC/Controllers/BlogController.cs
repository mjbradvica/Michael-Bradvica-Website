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

        [Route("routing-with-variables-in-blazor")]
        public IActionResult RoutingWithVariablesInBlazor() => View();

        [Route("refactoring-form-inputs-in-blazor")]
        public IActionResult RefactoringFormInputsInBlazor() => View();

        [Route("using-sass-in-asp-net-core")]
        public IActionResult UsingSassInAspNetCore() => View();

        [Route("blazor-in-memory-state-management-1-3")]
        public IActionResult BlazorInMemoryStateManagementPartOneOfThree() => View();

        [Route("blazor-in-memory-state-management-2-3")]
        public IActionResult BlazorInMemoryStateManagementPartTwoOfThree() => View();

        [Route("blazor-in-memory-state-management-3-3")]
        public IActionResult BlazorInMemoryStateManagementPartThreeOfThree() => View();

        [Route("blazor-advantages-via-a-progressive-web-app")]
        public IActionResult BlazorAdvantagesViaAProgressiveWebApp() => View();

        [Route("npredicatebuilder-an-alternative-to-repetitive-queries")]
        public IActionResult NPredicateBuilderAnAlternativeToRepetitiveQueries() => View();

        [Route("establish-coding-standards-early")]
        public IActionResult EstablishCodingStandardsEarly() => View();

        [Route("two-npm-packages-for-every-frontend-project")]
        public IActionResult TwoNpmPackagesForEveryFrontendProject() => View();

        [Route("two-nuget-packages-for-every-dotnet-project")]
        public IActionResult TwoNugetPackagesForEveryDotnetProject() => View();

        [Route("dependency-inversion-versus-inversion-of-control-versus-dependency-injection")]
        public IActionResult DependencyInversionVersusInversionOfControlVersusDependencyInjection() => View();

        [Route("application-services-are-conductors")]
        public IActionResult ApplicationServicesAreConductors() => View();
    }
}
