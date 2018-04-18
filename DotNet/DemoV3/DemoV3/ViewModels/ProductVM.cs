using DemoV3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoV3.ViewModels
{
    /* We use a view model when we want to display a custom property or class
     *
     *  something that is not already in the database already
     *  
     *  We can create as many view models as we want!!!
     *  Each view can have it's own view model if you want!!
     *  These are like custom classes
     */


    public class ProductVM
    {
        //this gets all of the Product model class
        public Product Product { get; set; }

    

       
        public int ProductId { get; set; }

        public decimal Price { get; set; }

        public string Size { get; set; }

        public string ProductName { get; set; }
        [Required]
        [DisplayName("Product Code")]
        //[ProductCodeValidator]
        public string ProductCode { get; set; }
        [Required(ErrorMessage = "Color Is Mandatory!!")]
        public string Color { get; set; }
        [Range(1, 500)]
        //since Required is above...we get the generic error message if this field is blank. this field has 2 types of validation.  Required and an if else in the controller!!!


        //we need to use a SelectedListItem because a dropdown always needs/uses a list..also in order to use this you need the using statment using System.web.mvc or it gives an error
        public List<SelectListItem> Styles { get; set; }


    }
}