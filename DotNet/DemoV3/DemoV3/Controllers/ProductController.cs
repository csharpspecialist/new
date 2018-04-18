using DemoV3.Models;
using DemoV3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoV3.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        static List<Product> products = new List<Product>();
        public ActionResult Index(string id)
        {
            Product p = new Product();
            p.ProductId = 1;
            p.ProductName = "mobile";
            p.ProductCode = "P001";
            p.Price = 10000;
            ViewBag.prod = p;


            return View("Index");
        }
        [HttpGet]

        public ActionResult LoadProductPage()
        {
            /*viewbag does not pass data from controller to view 
             tempdata store the values in session state so that it can
             be used again...viewbag and viewdata do not 
             
             */
            // ViewBag.Colors = Getsizes();
            ProductVM productVM = new ViewModels.ProductVM();

            productVM.Styles = GetStyles();
            return View("ProductEntry",productVM);
        }

        //you should always name your methods as post,get etc  if you are going to save data then the method should be a post!!
        [HttpPost]
        public ActionResult Save(ProductVM prodVM)
        {
            /*EVEN IF YOU PLACE DATA ANNOTATIONS ON/AT THE MODEL...YOU 
            STILL MUST HAVE Html.ValidationMessageFor(s => s.Price) MESSAGE
            AT THE VIEW FOR EACH FIELD !!!!
            */
            //example of server validation with the if statement below.
            //if (string.IsNullOrEmpty(prod.ProductName))
            //{
            //    ModelState.AddModelError("ProductName", "Product Name is mandatory!! Ya Maroon!!!");/* this name("ProductName") must match the name in the ProductEntry view in line 24 or 28 or else this validation will not work  */
            //}

            //if (prod.Price <= 5)
            //{
            //    ModelState.AddModelError("Price", "Product price must be greater than 0!! Dummy !!!");/* this name("Price") must match the name in the ProductEntry view in line 40 or this validation will not work  */
            //}



            if (ModelState.IsValid)
            {


                Product prod = new Product();

                prod.ProductId = prodVM.ProductId;
                prod.ProductCode = prodVM.ProductCode;
                prod.ProductName = prodVM.ProductName;
                prod.Price = prodVM.Price;
                prod.Color = prodVM.Color;

                products.Add(prod);
            
                //return View("Thankyou");
                return RedirectToAction("Summary");

            }

            /* before we were using viewbag...when we used viewbag we
             * had to have the viewbag declaration here to correspond
             * to line 35's viewbag above in order for this to work
             * since we switched to Tempdata we don't have to do that.
             */
            // ViewBag.Colors = Getsizes();
            prodVM.Styles = GetStyles();
            return View("ProductEntry",prodVM);

        }


        public ActionResult Summary()
        {
            return View("Summary", products);
        }

        public ActionResult Discount(decimal price)
        {

            decimal discountedPrice = price - (price * Convert.ToDecimal(.1));

            return PartialView("_Discount", discountedPrice);
        }

        public ActionResult Testing()
        {
            return PartialView("_Test");
        }


        //if we place nonaction here this method will never be called even if we call it in the Url "window"  it could be used for calculation or something like that
        [NonAction]
        public string test()
        {
            return "not working";
        }



        private List<SelectListItem> GetStyles()
        {
            List<SelectListItem> styles = new List<SelectListItem>();
            styles.Add(new SelectListItem() { Text = "Suave", Value = "1" });
            styles.Add(new SelectListItem() { Text = "Debonair", Value = "2" });
            styles.Add(new SelectListItem() { Text = "Sweet", Value = "3" });

            return (styles);
        }





    }
}