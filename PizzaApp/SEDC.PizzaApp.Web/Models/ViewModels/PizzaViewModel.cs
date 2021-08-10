﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Web.Models.Enums;

namespace SEDC.PizzaApp.Web.Models.ViewModels
{
    public class PizzaViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsOnPromotion { get; set; }
        public double Price { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public bool HasExtras { get; set; }
    }
}
