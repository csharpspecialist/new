using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Demo1.Models
{
    public class Product
    {
        [DisplayName("Product ID")]
        //ScaffoldColumn false means that this column will not show up wherever this model uses the    @Html.EditorForModel() command
        //[ScaffoldColumn(false)]
        public int ProductId { get; set; }
        [DisplayName("Product Code")]
        public string ProductCode { get; set; }
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        
        public decimal Price { get; set; }

        public string Color { get; set; }
    }
}