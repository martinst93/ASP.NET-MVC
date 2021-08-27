﻿using SEDC.PizzaApp.Domain.Enums;
using SEDC.PizzaApp.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.PizzaApp.DataAccess
{
    public static class CacheDb
    {
        public static int PizzaId = 3;
        public static List<Pizza> Pizzas = new List<Pizza>
        {
            new Pizza
            {
                Id = 1,
                Name = "Margarita",
                IsOnPromotion = true,
                Price = 7,
                PizzaSize = PizzaSize.Large
            },
            new Pizza
            {
                Id = 2,
                Name = "Napolitana",
                IsOnPromotion = false,
                Price = 3,
                PizzaSize = PizzaSize.Medium
            },
            new Pizza
            {
                Id = 3,
                Name = "Capri",
                IsOnPromotion = false,
                Price = 4,
                PizzaSize = PizzaSize.Family
            },
        };

        public static int UserId = 3;
        public static List<User> Users = new List<User>
        {
            new User
            {
                Id=1,
                FirstName="John",
                LastName="Smith",
                Address="Partizanska bb.",
                Phone=111222333
            },
            new User
            {
                Id=2,
                FirstName="John",
                LastName="Doe",
                Address="Partizanska br 19",
                Phone=111122222
            },
            new User
            {
                Id = 3,
                FirstName = "Alex",
                LastName ="Smith",
                Address = "Varshavska br.13",
                Phone=123456789
            }
        };

        public static int OrderId = 3;
        public static List<Order> Orders = new List<Order>
        {
            new Order
            {
                Id=1,
                PaymentMethod= PaymentMethod.Card,
                User= Users.First(),
                Pizza= Pizzas.First(),
                Price= Pizzas.First().Price,
                Delivered=true,
                PizzaStore = "Jakomo"
            },
            new Order
            {
                Id=2,
                PaymentMethod=PaymentMethod.Cash,
                User=Users.FirstOrDefault(x=>x.Id==2),
                Pizza= Pizzas.FirstOrDefault(x=>x.Id==2),
                Price= Pizzas.FirstOrDefault(x=>x.Id==2).Price,
                Delivered=false,
                PizzaStore = "Mama Italiana"
            },
            new Order
            {
                Id= 3,
                PaymentMethod= PaymentMethod.Card,
                User=Users.Last(),
                Pizza= Pizzas.Last(),
                Price= Pizzas.Last().Price,
                Delivered=false,
                PizzaStore ="Domino's"
            }
        };

        public static int FeedbacksId = 3;
        public static List<Feedback> Feedbacks = new List<Feedback>
        {
            new Feedback
            {
                Id = 1,
                Name = "First Feedback",
                Email = "fed@gmail.com",
                Message = "First message"
            },
            new Feedback
            {
                Id = 2,
                Name = "Second Feedback",
                Email = "fed2@gmail.com",
                Message = "Second message"
            },
            new Feedback
            {
                Id = 3,
                Name = "Third Feedback",
                Email = "fe3@gmail.com",
                Message = "Third message"
            }
        };
    }
}
