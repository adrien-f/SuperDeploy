using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;

namespace EveAuth.Front.TagHelpers
{
    [TargetElement(Attributes = "error")]
    public class FormErrorTagHelper : TagHelper
    {
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (ViewContext.ViewData?.ModelState?.ErrorCount > 0)
            {
                output.Attributes["class"] = output.Attributes["class"].Value + " has-error";
            }
        }
    }
}
