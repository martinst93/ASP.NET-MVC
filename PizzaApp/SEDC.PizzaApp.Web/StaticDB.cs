﻿using SEDC.PizzaApp.Web.Models;
using SEDC.PizzaApp.Web.Models.Enums;
using SEDC.PizzaApp.Web.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Web
{
    public class StaticDB
    {
        public static List<Pizza> Pizzas = new List<Pizza>
        {
            new Pizza
            {
                Id = 1,
                Name = "Margarita",
                IsOnPromotion = true,
                Price = 7,
                PizzaSize = PizzaSize.Normal,
                HasExtras = true
            },
            new Pizza
            {
                Id = 2,
                Name = "Napolitana",
                IsOnPromotion = false,
                Price = 3,
                PizzaSize = PizzaSize.Family,
                HasExtras = false
            },
            new Pizza
            {
                Id = 3,
                Name = "Capri",
                IsOnPromotion = false,
                Price = 4,
                PizzaSize = PizzaSize.Normal,
                HasExtras = false
            },
        };

        public static List<User> Users = new List<User>
        {
            new User
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith",
                Address = "PAr",
                Phone = 1232311
            },
            new User
            {
                Id = 2,
                FirstName = "Sally",
                LastName = "Johnes",
                Address = "Tas",
                Phone = 5778
            },
            new User
            {
                Id = 3,
                FirstName = "Keath",
                LastName = "Smith",
                Address = "Dar",
                Phone = 3425432
            },
        };

        public static List<Order> Orders = new List<Order>
        {
            new Order
            {
                Id = 1,
                PaymentMethod = Models.Enums.PaymentMethod.Card,
                User = Users.First(),
                Pizza = Pizzas.First(),
                Price = Pizzas.First().Price
            },
            new Order
            {
                Id = 2,
                PaymentMethod = Models.Enums.PaymentMethod.Cash,
                User = Users.FirstOrDefault(x => x.Id == 2),
                Pizza = Pizzas.FirstOrDefault(x => x.Id == 2),
                Price = Pizzas.FirstOrDefault(x => x.Id == 2).Price
            },
            new Order
            {
                Id = 3,
                PaymentMethod = Models.Enums.PaymentMethod.Card,
                User = Users.FirstOrDefault(x => x.Id == 3),
                Pizza = Pizzas.FirstOrDefault(x => x.Id == 3),
                Price = Pizzas.FirstOrDefault(x => x.Id == 3).Price
            },
        };
    }
}
