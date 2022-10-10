namespace MB.MVC.TagHelpers
{
    using Microsoft.AspNetCore.Razor.TagHelpers;

    public class BlogPostTagHelper : TagHelper
    {
        public string Title { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.PreContent.SetHtmlContent(
                                             "<div class=\"container\">" +
                                             "<article class=\"content\">" +
                                             $"<h2 class=\"title is-3\">{Title}</h2>");
            output.PostContent.SetHtmlContent("</article>" +
                                              "</div>");

            base.Process(context, output);
        }
    }
}
