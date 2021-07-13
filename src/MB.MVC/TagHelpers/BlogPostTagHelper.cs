namespace MB.MVC.TagHelpers
{
    using Microsoft.AspNetCore.Razor.TagHelpers;

    public class BlogPostTagHelper : TagHelper
    {
        public string Title { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.PreContent.SetHtmlContent($"<h4 class=\"title is-4 block\">{Title}</h4>" +
                                             "<section class=\"section\">" +
                                             "<article class=\"content\">");
            output.PostContent.SetHtmlContent("</article class=\"content\">" +
                                              "</section class=\"section\">");

            base.Process(context, output);
        }
    }
}
