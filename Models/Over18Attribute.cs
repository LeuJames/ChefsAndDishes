using System.ComponentModel.DataAnnotations;
using System;

namespace ChefsAndDishes.Models
{
  public class Over18Attribute : ValidationAttribute
  {
      protected override ValidationResult IsValid(object value, ValidationContext validationContext)
      {
          if ((DateTime) value > DateTime.Now.AddYears(-18))
              return new ValidationResult("Chefs must be 18 years or older");
          return ValidationResult.Success;
      }
  }
}
