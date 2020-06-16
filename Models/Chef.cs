using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace ChefsAndDishes.Models
    {
        public class Chef
        {

            [Key]
            public int ChefId { get; set; }

            [Required]
            [Display(Name = "First Name:")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Last Name:")]
            public string LastName { get; set; }

            [Required]
            [Display(Name = "Date of Birth")]

            [DataType(DataType.Date)]
            [Over18]
            public DateTime DOB { get; set; }

            public List<Dish> Dishes {get;set;}

            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;

            // public static int Age()
            // {
            //   DateTime today = DateTime.Today;
            //   int month = today.Month - dob.Month;
            //   int years = today.Year - dob.Year;
            //   if(today.Day < dob.Day)
            //   {
            //     month--;
            //   }
            //   if(month < 0)
            //   {
            //     years--;
            //     month += 12;
            //   }
            //   int days = (today - dob.AddMonths((years * 12) + month)).Days;
            //   return years;
            // }


        }
    }