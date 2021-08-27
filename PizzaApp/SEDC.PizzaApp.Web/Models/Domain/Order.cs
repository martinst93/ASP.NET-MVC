using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Web.Models.Enums;

namespace SEDC.PizzaApp.Web.Models.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public PizzaName PizzaName { get; set; }
        public double Price { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public bool Delivered { get; set; }
        public string PizzaStore { get; internal set; }
    }
}
