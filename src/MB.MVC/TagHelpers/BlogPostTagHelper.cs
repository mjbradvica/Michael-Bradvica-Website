namespace MB.MVC.TagHelpers
{
    using Microsoft.AspNetCore.Razor.TagHelpers;

    public class BlogPostTagHelper : TagHelper
    {
        public string Title { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.PreContent.SetHtmlContent("<section class=\"section\">" +
                                             "<div class=\"container\">" +
                                             $"<h4 class=\"title is-4\">{Title}</h4>" +
                                             "<article class=\"content\">");
            output.PostContent.SetHtmlContent("</article>" +
                                              "</div>" +
                                              "</section>");

            base.Process(context, output);
        }
    }
}
