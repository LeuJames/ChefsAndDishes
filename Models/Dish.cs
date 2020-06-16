using System.ComponentModel.DataAnnotations;
using System;

    namespace ChefsAndDishes.Models
    {
        public class Dish
        {

            [Key]
            public int DishId { get; set; }

            [Required]
            [Display(Name = "Dish Name:")]
            public string Name { get; set; }

            [Required]
            [Display(Name = "# of Calories:")]
            [Range(0, 10000000)]
            public int Calories { get; set; }

            [Required]
            [Display(Name = "Tastiness Rating:")]
            [Range(0, 5)]
            public int Tastiness { get; set; }

            [Required]
            [Display(Name = "Description:")]
            public string Description { get; set; }

            public int ChefId {get;set;}

            public Chef Preparer {get; set;}


            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;
        }
    }