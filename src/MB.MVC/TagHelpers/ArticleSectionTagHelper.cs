namespace MB.MVC.TagHelpers
{
    using Microsoft.AspNetCore.Razor.TagHelpers;

    public class ArticleSectionTagHelper : TagHelper
    {
        public string SectionTitle { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.PreContent.SetHtmlContent("<section class=\"section\">" +
                                             $"<h3 class=\"title is-4\">{SectionTitle}</h2>");

            output.PostContent.SetHtmlContent("</section>");

            base.Process(context, output);
        }
    }
}
