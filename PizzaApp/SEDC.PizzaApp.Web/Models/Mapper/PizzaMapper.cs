using SEDC.PizzaApp.Web.Models.ViewModels;
using SEDC.PizzaApp.Web.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Web.Models.Mapper
{
    public static class PizzaMapper
    {
        public static PizzaViewModel PizzaDetailsViewModel(Pizza pizza)
        {
            if(pizza.HasExtras == true)
            {
                return new PizzaViewModel
                {
                    Id = pizza.Id,
                    Name = pizza.Name,
                    Price = pizza.Price + 10,
                    PizzaSize = pizza.PizzaSize,
                    HasExtras = pizza.HasExtras,
                    IsOnPromotion = pizza.IsOnPromotion
                };
            }
            else
            {
                return new PizzaViewModel
                {
                    Id = pizza.Id,
                    Name = pizza.Name,
                    Price = pizza.Price,
                    PizzaSize = pizza.PizzaSize,
                    HasExtras = pizza.HasExtras,
                    IsOnPromotion = pizza.IsOnPromotion
                };
            }
        }
    }
}
