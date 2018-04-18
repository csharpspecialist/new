using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        /*we can place specific routes right above each method/view!!!  In order for this to work we must add the command   routes.MapMvcAttributeRoutes();
        in the RouteConfig file at the top of the file..under the ignore routes line!!!
        */
        [Route("Hello")]
        public string GetName()
        {
            return "Big Dog is in the house";
        }

        [Route("Leave")]
        public string GetOut()
        {
            return "WE R Outta Here!!!";
        }

        public ActionResult Other()
        {
            return View("~/Views/product/tryagain");
        }





        public void Fizz()
        {

            int realVal;
            Console.WriteLine("Give me a number to try out");

            string trynum = Console.ReadLine();

            int.TryParse(trynum, out realVal );

            if (realVal % 3 == 0 && realVal % 5 == 0)
            {
                Console.WriteLine("Fizzbuzz");
            }





        }


    }
}