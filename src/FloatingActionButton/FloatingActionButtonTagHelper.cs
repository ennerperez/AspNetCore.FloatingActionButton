using System.Collections;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Microsoft.AspNetCore.Razor.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("FloatingActionButton")]
    public class FloatingActionButtonTagHelper : TagHelper
    {
        private readonly IViewComponentHelper _viewComponentHelper;

        public FloatingActionButtonTagHelper(IViewComponentHelper viewComponentHelper)
        {
            _viewComponentHelper = viewComponentHelper;
        }

        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public FloatingAction Model { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            ((IViewContextAware)_viewComponentHelper).Contextualize(ViewContext);

            //var model = (FloatingAction)context.AllAttributes["model"]?.Value;

            var content = _viewComponentHelper.InvokeAsync(typeof(FloatingActionButton), new { model = Model });
            content.RunSynchronously();
            output.Content.SetHtmlContent(content.Result);
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            ((IViewContextAware)_viewComponentHelper).Contextualize(ViewContext);

            //var model = (FloatingAction)context.AllAttributes["model"]?.Value;

            var content = await _viewComponentHelper.InvokeAsync(typeof(FloatingActionButton), new { model = Model });//, new {name = Name});
            output.Content.SetHtmlContent(content);
        }
    }
}