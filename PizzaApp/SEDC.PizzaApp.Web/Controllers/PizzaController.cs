using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Web.Models;
using SEDC.PizzaApp.Web.Models.Mapper;
using SEDC.PizzaApp.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Web.Controllers
{
    //[Route("Pizza")]
    public class PizzaController : Controller
    {
        //[Route("Pizzas")]
        public IActionResult Index()
        {
            ViewData.Add("Title", "Pizza Home Page");
            ViewData.Add("NumberOfApp", 12);

            var firstPizza = StaticDB.Pizzas.First();
            //ViewData.Add("Pizza", firstPizza);

            ViewBag.Name = "SEDC Academy";
            ViewBag.NumberOfPizzas = 2;
            ViewBag.Pizza = firstPizza;

            List<Pizza> pizzas = StaticDB.Pizzas;
            List<PizzaViewModel> pizzaDetails = new List<PizzaViewModel>();

            foreach (Pizza pizza in pizzas)
            {
                pizzaDetails.Add(PizzaMapper.PizzaDetailsViewModel(pizza));
            }

            return View(pizzaDetails);
            //return View();

            //return new JsonResult(StaticDB.Pizzas);
        }

        //[Route("Details")]
        public IActionResult Details(int? id)
        {
            if (id != null)
            {
                var pizza = StaticDB.Pizzas.FirstOrDefault(x => x.Id == id);
                ViewData.Add("Title", "Pizza Details Page");
                ViewBag.Pizza = pizza;

                return View("~/Views/Pizza/Details.cshtml");
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
        }
    }
}
