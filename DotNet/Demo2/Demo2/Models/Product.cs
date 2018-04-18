using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Demo2.Custom;

namespace Demo2.Models
{
    public class Product
    {
        [DisplayName("Product ID")]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        [Required]
        [DisplayName("Product Code")]
        //[ProductCodeValidator]
        public string ProductCode { get; set; }
        [Required(ErrorMessage = "Color Is Mandatory!!")]
        public string Color { get; set; }
        [Range (1,500)]
        //since Required is above...we get the generic error message if this field is blank. this field has 2 types of validation.  Required and an if else in the controller!!!
        public decimal Price { get; set; }

        public string Size { get; set; }
    }
}