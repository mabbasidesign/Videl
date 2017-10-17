using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Videl.Models
{
    public class Min18YearsIfMember : ValidationAttribute
    {
        //protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        //{
        //    var customer = (Customer)validationContext.ObjectInstance;

        //    //if (customer.MemberShipTypeId == 0 || customer.MemberShipTypeId == 1)
        //    //    return ValidationResult.Success;

        //    if (customer.BirthDay == null)
        //        return new ValidationResult("Birtday is required.");

        //    var age = DateTime.Today.Year - customer.BirthDay.Value.Year;

        //    return (age >= 18)
        //        ? ValidationResult.Success
        //        : new ValidationResult("Customer Should be atleast 18 yers old");
        //}


        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.BirthDay == null)
                return new ValidationResult("Customer must b atleast 18 years old");

            var age = DateTime.Now.Year - customer.BirthDay.Value.Year;

            return (age >= 18)
               ? ValidationResult.Success
               : new ValidationResult("Customer Should be atleast 18 yers old");

        }

    }
}