using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo2.Custom
{
    //u must inherit from validation attribute + bring in it dataAnnotation
    public class ProductCodeValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string code = (string)value;


            if(code.StartsWith("P", StringComparison.InvariantCultureIgnoreCase))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Product code should start with P");
            }
        }


    }
}