using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Demo1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //line 17 allows us to use attribute routing in the controller!!!
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
 

     
            //we can have as many routes as we want!!!  Each has to have a diff name though!!!  In order for this url to work we must spell it perfectly in the browser as localhost:number/test/getname or forgetaboutit!!!
            routes.MapRoute(
            name: "Default1",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Test", action = "GetName", id = UrlParameter.Optional }
        );

                    routes.MapRoute(
           name: "Default2",
           url: "{controller}/{action}/{id}",
           defaults: new { controller = "test", action = "Index", id = UrlParameter.Optional }
              );



        }
    }
}
