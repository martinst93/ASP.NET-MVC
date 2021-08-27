using E_Store.Domain.Models;
using E_Store.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store.Models.Mapper
{
    public static class ProductMapper
    {

        public static ProductViewModel ProductToShowDetailsViewModel(Product product)
        {
            return new ProductViewModel
            {
                Id = product.Id,
                Category = product.Category,
                Name = product.Name,
                Promotion = product.Promotion,
                TypeOfPromotion = product.TypeOfPromotion,
                Price = product.Price,
                Description = product.Description,
                Review = product.Review,
                Image = product.Image
            };
        }

        public static BlackFridayViewModel ProductsOnPromotionBfViewModel(Product product)
        {
           
            if (product.TypeOfPromotion == TypeOfPromotion.BlackFriday)
            {
                return new BlackFridayViewModel
                {
                    Id = product.Id,
                    Category = product.Category,
                    Name = product.Name,
                    Promotion = product.Promotion,
                    TypeOfPromotion = TypeOfPromotion.BlackFriday,
                    Price = product.Price,
                    Description = product.Description,
                    Review = product.Review,
                    Image = product.Image
                };
            }
            return new BlackFridayViewModel { };

        }

        public static CyberMondayViewModel ProductsOnPromotionCmViewModel(Product product)
        {

            if (product.TypeOfPromotion == TypeOfPromotion.CyberMonday)
            {
                return new CyberMondayViewModel
                {
                    Id = product.Id,
                    Category = product.Category,
                    Name = product.Name,
                    Promotion = product.Promotion,
                    TypeOfPromotion = TypeOfPromotion.CyberMonday,
                    Price = product.Price,
                    Description = product.Description,
                    Review = product.Review,
                    Image = product.Image
                };
            }
            return new CyberMondayViewModel { };
        }
    }
}
