using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaasData.Helpers
{
    public static class CustomHtmlHelpers
    {
        public static MvcHtmlString Button(
            this HtmlHelper helper,
            string type,
            string value)
        {
            TagBuilder tb = new TagBuilder("input");

            tb.Attributes.Add("type", type);
            tb.Attributes.Add("value", value);

            return new MvcHtmlString(tb.ToString());
        }
    }
}