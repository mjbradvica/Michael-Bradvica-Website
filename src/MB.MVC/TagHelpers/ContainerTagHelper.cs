namespace MB.MVC.TagHelpers
{
    using System.Text.Encodings.Web;
    using Microsoft.AspNetCore.Mvc.TagHelpers;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    public class ContainerTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";

            output.AddClass("container", HtmlEncoder.Default);

            base.Process(context, output);
        }
    }
}
