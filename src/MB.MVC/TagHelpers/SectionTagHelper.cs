namespace MB.MVC.TagHelpers
{
    using System.Text.Encodings.Web;
    using Microsoft.AspNetCore.Mvc.TagHelpers;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    public class SectionTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.AddClass("section", HtmlEncoder.Default);

            base.Process(context, output);
        }
    }
}
