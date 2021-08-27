﻿using SEDC.PizzaApp.Web.Models.Domain;
using SEDC.PizzaApp.Web.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Web.Models.ViewModels
{
    public class OrderDetailsViewModel
    {
        public int Id { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public PizzaName PizzaName { get; set; }
        public string UserFullName { get; set; }
        public double Price { get; set; }
        public string Address { get; set; }
        public bool Delivered { get; internal set; }
        public string PizzaStore { get; internal set; }
    }
}
