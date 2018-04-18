using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo1.Models;

namespace Demo1.Controllers
{
    public class PracticeController : Controller
    {
        // GET: Practice
        public ActionResult Index()
        {
            Product prod = new Product();


            return View();
            //return View("Index");
        }

        public ActionResult What()
        {
            /*showing how to use viewdata...show up as planned in the
            View itself!!!

            */
            ViewData["Place"] = "Like a Boss";
            return View("Index");
           
        }

        public ActionResult Picture()
        {
            //don't run this method... it just downloads the image that you put int he images folder!!!
            return File(@"~\pics\JasmineJae.jpg","img/jpg");

        }





    }



}




