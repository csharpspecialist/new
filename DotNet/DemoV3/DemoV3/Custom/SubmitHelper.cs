using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoV3.Custom
{
    public static class SubmitHelper
    {

        public static MvcHtmlString SubmitButton(this HtmlHelper helper, string name)
        {
            string button = string.Format("<input type='submit' value='{0}' />", name);
            MvcHtmlString str = new MvcHtmlString(button);
            return str;
        }


    }
}