namespace MB.MVC.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Security.Policy;

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

        [Route("covariance-and-contravariance-quick-guide")]
        public IActionResult CovarianceAndContravarianceQuickGuide() => View();

        [Route("single-pathway")]
        public IActionResult SinglePathway() => View();

        [Route("your-application-is-not-the-database")]
        public IActionResult YourApplicationIsNotTheDatabase() => View();

        [Route("simplifying-ado-net-boilerplate")]
        public IActionResult SimplifyingAdoNetBoilerplate() => View();

        [Route("encapsulation-with-dapper")]
        public IActionResult EncapsulationWithDapper() => View();

        [Route("mimicking-usestate-in-vue")]
        public IActionResult MimickingUseStateInVue() => View();

        [Route("navigating-vues-onmounted-ambiguity")]
        public IActionResult NavigatingVuesOnMountedAmbiguity() => View();

        [Route("avoid-vue-component-events")]
        public IActionResult AvoidVueComponentEvents() => View();

        [Route("dependency-injection-magic-number")]
        public IActionResult DependencyInjectionMagicNumber() => View();

        [Route("always-initialize-state")]
        public IActionResult AlwaysInitializeState() => View();

        [Route("any-and-typescript-are-mutually-exclusive")]
        public IActionResult AnyAndTypeScriptAreMutuallyExclusive() => View();

        [Route("mimicking-use-computed-in-react")]
        public IActionResult MimickingUseComputedInReact() => View();

        [Route("specify-typescript-generics")]
        public IActionResult SpecifyTypeScriptGenerics() => View();

        [Route("avoid-multi-slot-content-projection")]
        public IActionResult AvoidMultiSlotContentProjection() => View();

        [Route("code-is-a-by-product")]
        public IActionResult CodeIsAByProduct() => View();

        [Route("testing-is-insurance")]
        public IActionResult TestingIsInsurance() => View();

        [Route("do-not-have-software-babies")]
        public IActionResult DoNotHaveSoftwareBabies() => View();

        [Route("use-value-defaults")]
        public IActionResult UseValueDefaults() => View();

        [Route("avoid-bad-types")]
        public IActionResult AvoidBadTypes() => View();

        [Route("mimicking-use-reducer-in-vue-and-angular")]
        public IActionResult MimickingUseReducerInVueAndAngular() => View();

        [Route("hook-return-types")]
        public IActionResult HookReturnTypes() => View();

        [Route("encapsulate-your-requests")]
        public IActionResult EncapsulateYourRequests() => View();

        [Route("differentiating-local-intermediate-and-global-state")]
        public IActionResult DifferentiatingLocalIntermediateAndGlobalState() => View();

        [Route("full-encapsulation-in-ef")]
        public IActionResult FullEncapsulationInEF() => View();

        [Route("n-predicate-builder-updated-to-53")]
        public IActionResult NPredicateBuilderUpdatedTo53() => View();
    }
}
