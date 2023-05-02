namespace MB.MVC.Models
{
    using System.Collections.Generic;

    public static class BlogPosts
    {
        public static IEnumerable<BlogPost> AllPosts()
        {
            return new List<BlogPost>
            {
                BlogPost.AddPost("DoNotHaveSoftwareBabies", "Do Not Have (Software) Babies"),
                BlogPost.AddPost("TestingIsInsurance", "Testing Is Insurance"),
                BlogPost.AddPost("CodeIsAByProduct", "Code is a By-product"),
                BlogPost.AddPost("AvoidMultiSlotContentProjection", "Avoid Multi-Slot Content Projection"),
                BlogPost.AddPost("SpecifyTypeScriptGenerics", "Specify TypeScript Generics"),
                BlogPost.AddPost("MimickingUseComputedInReact", "Mimicking useComputed in React"),
                BlogPost.AddPost("AnyAndTypeScriptAreMutuallyExclusive", "Any and TypeScript are Mutually Exclusive"),
                BlogPost.AddPost("AlwaysInitializeState", "Always Initialize State"),
                BlogPost.AddPost("DependencyInjectionMagicNumber", "Dependency Injection Magic Number"),
                BlogPost.AddPost("AvoidVueComponentEvents", "Avoid Vue Component Events"),
                BlogPost.AddPost("NavigatingVuesOnMountedAmbiguity", "Navigating Vue's onMounted Ambiguity"),
                BlogPost.AddPost("MimickingUseStateInVue", "Mimicking useState in Vue"),
                BlogPost.AddPost("EncapsulationWithDapper", "Encapsulation with Dapper"),
                BlogPost.AddPost("SimplifyingAdoNetBoilerplate", "Simplifying ADO.NET Boilerplate"),
                BlogPost.AddPost("YourApplicationIsNotTheDatabase", "Your Application is NOT the Data(base)"),
                BlogPost.AddPost("SinglePathway", "Single Pathway"),
                BlogPost.AddPost("CovarianceAndContravarianceQuickGuide", "Covariance and Contravariance Quick Guide"),
                BlogPost.AddPost("ApplicationServicesAreConductors", "Application Services are Conductors"),
                BlogPost.AddPost("DependencyInversionVersusInversionOfControlVersusDependencyInjection", "Dependency Inversion vs. Inversion of Control vs. Dependency Injection"),
                BlogPost.AddPost("TwoNugetPackagesForEveryDotnetProject", "Two NuGet Packages for Every dotnet Project"),
                BlogPost.AddPost("TwoNpmPackagesForEveryFrontendProject", "Two npm Packages for Every Frontend Project"),
                BlogPost.AddPost("EstablishCodingStandardsEarly", "Establish Coding Standards Early"),
                BlogPost.AddPost("NPredicateBuilderAnAlternativeToRepetitiveQueries", "NPredicateBuilder, an Alternative to Repetitive Queries"),
                BlogPost.AddPost("BlazorAdvantagesViaAProgressiveWebApp", "Blazor Advantages via a Progressive Web App"),
                BlogPost.AddPost("BlazorInMemoryStateManagementPartThreeOfThree", "Blazor In-Memory State Management Part 3"),
                BlogPost.AddPost("BlazorInMemoryStateManagementPartTwoOfThree", "Blazor In-Memory State Management Part 2"),
                BlogPost.AddPost("BlazorInMemoryStateManagementPartOneOfThree", "Blazor In-Memory State Management Part 1"),
                BlogPost.AddPost("UsingSassInAspNetCore", "Using Sass in ASP.NET Core, Including Blazor"),
                BlogPost.AddPost("RefactoringFormInputsInBlazor", "Refactoring Form Inputs in Blazor"),
                BlogPost.AddPost("RoutingWithVariablesInBlazor", "Routing with Variables in Blazor"),
                BlogPost.AddPost("JustBecauseYouCanDoesNotMeanYouShould", "Just Because You Can, Does Not Mean You Should"),
                BlogPost.AddPost("EmbracingComponentArchitecture", "Embracing Component Architecture"),
                BlogPost.AddPost("BlazorHostingModels", "Blazor Hosting Models"),
                BlogPost.AddPost("YourApplicationIsNotBlazor", "Your Application is Not Blazor"),
                BlogPost.AddPost("MinimizingJavaScriptInteropInBlazor", "Minimizing JavaScript Interop in Blazor"),
                BlogPost.AddPost("ThingsToRememberWithBlazor", "Things to Remember with Blazor"),
                BlogPost.AddPost("PurposeOfTheRepositoryPattern", "Purpose of the Repository Pattern"),
                BlogPost.AddPost("ChainOfResponsibilityForDependencyInjection", "Chain of Responsibility for Dependency Injection"),
                BlogPost.AddPost("OneLineADay", "One Line a Day"),
            };
        }
    }
}
