using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ChefsAndDishes.Models;

namespace ChefsAndDishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Chef> AllChefs = dbContext.Chefs.Include(c => c.Dishes).OrderByDescending(c => c.CreatedAt).ToList();

            return View(AllChefs);
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            List<Dish> AllDishes = dbContext.Dishes.Include(d => d.Preparer).OrderByDescending(d => d.CreatedAt).ToList();
            return View(AllDishes);
        }

        [HttpGet("new/dish")]
        public IActionResult NewDish()
        {
            ViewBag.Chefs  = dbContext.Chefs.ToList();
            return View();
        }

        [HttpGet("new/chef")]
        public IActionResult NewChef()
        {
            return View();
        }

        [HttpPost("create/dish")]
        public IActionResult CreateDish(Dish newDish)
        {
          if(ModelState.IsValid)
          {
            dbContext.Add(newDish);
            dbContext.SaveChanges();
            return Redirect ("/dishes");
          }
          else{
            return View("NewDish");
          }
        }

        [HttpPost("create/Chef")]
        public IActionResult CreateChef(Chef newChef)
        {
          if(ModelState.IsValid)
          {
            dbContext.Add(newChef);
            dbContext.SaveChanges();
            return Redirect ("/");
          }
          else{
            return View("NewChef");
          }
        }

    }
}