namespace MB.MVC.Models
{
    using System.Collections.Generic;

    public static class BlogPosts
    {
        public static IEnumerable<BlogPost> AllPosts()
        {
            return new List<BlogPost>
            {
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
