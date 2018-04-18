using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo1.Custom
{
    public static class SubmitHelper
    {
        public static MvcHtmlString SubmitButton(this HtmlHelper helper, string name)
        {
            string button = string.Format("<input type='submit' value='{0}' />", name);

            MvcHtmlString str = new MvcHtmlString(button);
            return str;
        }

        /* if we want to use this custom helper method we need to import its namespace into a view by writing the @using Demo1.Custom...which is the name of our project and the Custom folder.  This is done in the Product entry view line # 3, then the submitbutton method is used in line # 68 and line 155.

        OR A BETTER WAY!!!!
        add this line to the View web config file
           <add namespace="Demo1.Custom" /> 
           then all of the views can use this method without adding a using statement to them.


         */




    }
}