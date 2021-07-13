namespace MB.MVC.TagHelpers
{
    using Microsoft.AspNetCore.Razor.TagHelpers;

    public class ImageTagHelper : TagHelper
    {
        public string Src { get; set; }

        public string Alt { get; set; }

        public string Caption { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetHtmlContent(
                "<figure class=\"image\">" +
                $"<img Src=\"{Src}\" Alt=\"{Alt}\">" +
                $"<figcaption>{Caption}</figcaption>" +
                "</figure>");

            base.Process(context, output);
        }
    }
}
