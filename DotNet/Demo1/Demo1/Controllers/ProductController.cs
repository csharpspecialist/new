using Demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo1.Controllers
{
    public class ProductController : Controller
    {

        List<Product> products = new List<Product>();

        // GET: Product
        public ActionResult Index(string id)
        {

            Product p = new Product();
            p.ProductId = 1;
            p.ProductName = "Laptop";
            p.ProductCode = "P1001";
            p.Price = 1001;

            ViewBag.prod = p;
          
            return View();
        }


        public ActionResult Display()
        {
            /*
             I created this method just to show that the viewbag objct could be used again...It works!!
             * */
            Product p = new Product();
            p.ProductId = 2;
            p.ProductName = "Microphone";
            p.ProductCode = "P2501";
            p.Price = 2002;

            ViewBag.prod = p;

            return View();
        }


        public ActionResult LoadProductPage()
        {

            return View("ProductEntry");
        }

        //public ActionResult Save(string ProductId, string ProductName, string ProductCode, decimal Price)
        //{

        //    return View("Thanks");
        //}

            //the code below shortened the parameters of the commented out save method above!!!!
        public ActionResult Save(Product prod)
        {
            products.Add(prod);
            ViewData["products"] = products;

            //we can use logic as to which view is shown also
            if (prod.ProductId > 5000)
            {
                return View("Thanks");
            }
            else
            {
                //the first  return View("Summary");  below will work only if we have written   @using Demo1.Models   at the top of the page in the summary view's html page
                //  return View("Summary");

                // this code below will work only if we place the   @model List<Product> code at the top of the page of the summary view's html page

                return RedirectToAction("Summary");
            }
            
        }

        public ActionResult TryAgain()
        {

            return View();
        }

        //we can also call a view from a different controller as shown below.

     
        public ActionResult Nice()
        {
            return View("Nice");
        }


        public ActionResult Summary(Product prod)
        {
            products.Add(prod);
            return View("Summary", products);
        }


    }
}