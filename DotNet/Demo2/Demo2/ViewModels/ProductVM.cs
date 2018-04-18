using Demo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo2.ViewModels
{
    public class ProductVM
    {
        //this gets all of the Product model class
        public Product Product { get; set; }

        //we need to use a SelectedListItem because a dropdown always needs/uses a list..also in order to use this you need the using statment using System.web.mvc or it gives an error
        public List<SelectListItem> Colors { get; set; }


    }
}