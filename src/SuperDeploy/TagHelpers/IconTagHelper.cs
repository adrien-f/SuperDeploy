using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;

namespace EveAuth.Front.TagHelpers
{
    public class IconTagHelper : TagHelper
    {
        public string Name { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes["class"] = $"fa fa-fw fa-{Name}";
            output.TagName = "i";
        }
    }
}
