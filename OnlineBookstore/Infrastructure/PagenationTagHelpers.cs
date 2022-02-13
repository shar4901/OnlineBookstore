﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using OnlineBookstore.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-number")]
    public class PagenationTagHelpers : TagHelper
    {
        private IUrlHelperFactory uhf;

        public PagenationTagHelpers(IUrlHelperFactory temp)
        {
            uhf = temp;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext vc { get; set; }

        public PageInfo PageNumber { get; set; }
        public string PageAction { get; set; }

        
        public override void Process (TagHelperContext thc, TagHelperOutput tho)
        {
            IUrlHelper uh = uhf.GetUrlHelper(vc);

            TagBuilder final = new TagBuilder("div");

            for (int i = 1; i <= PageNumber.TotalPages; i++)
            {
                TagBuilder tb = new TagBuilder("a");
                tb.Attributes["href"] = uh.Action(PageAction, new { pageNum = i });
                tb.InnerHtml.Append("Page: " + i.ToString() + "\t");

                final.InnerHtml.AppendHtml(tb);
            }

            tho.Content.AppendHtml(final.InnerHtml);
        }
    }

}
