using SEDC.PizzaApp.Web.Models.Domain;
using SEDC.PizzaApp.Web.Models.ViewModels;
using SEDC.PizzaApp.Web.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Web.Models.Mapper
{
    public static class OrderMapper
    {
        public static OrderDetailsViewModel OrderToOrderDetailsViewModel(Order order)
        {
            return new OrderDetailsViewModel
            {
                Id = order.Id,
                PaymentMethod = order.PaymentMethod,
                PizzaName = order.PizzaName,
                UserFullName = $"{order.User.FirstName} {order.User.LastName}",
                Price = order.Price,
                Address = order.User.Address,
                Delivered = order.Delivered,
                PizzaStore = order.PizzaStore
            };
        }

        public static OrderViewModel OrderToOrderViewModel(Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                PaymentMethod = order.PaymentMethod,
                PizzaName = order.PizzaName,
                PizzaStore = order.PizzaStore,
                Price = order.Price,
                Delivered = order.Delivered,
                UserId = order.User.Id
            };
        }

        public static OrderCreateViewModel OrderToOrderCreateViewModel(Order order)
        {
            return new OrderCreateViewModel
            {
                Id = order.Id,
                PaymentMethod = order.PaymentMethod,
                PizzaName = order.PizzaName
            };
        }
    }
}