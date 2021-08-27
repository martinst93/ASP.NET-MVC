using E_Store.Domain.Models;
using E_Store.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Store.DataAccess
{
    public static class StaticDB
    {
        public static int ProductId = 5;
        public static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Category = Category.Phone,
                Name = "Samsung Galaxy M32",
                Description = "New Phone",
                Price = 200,
                Promotion = false,
                TypeOfPromotion = TypeOfPromotion.None,
                Review = "4 stars",
                Image = "1.jpeg"
            },
            new Product
            {
                Id = 2,
                Category = Category.Laptop,
                Name = "Lenovo G500S",
                Description = "New Laptop",
                Price = 250,
                Promotion = true,
                TypeOfPromotion = TypeOfPromotion.BlackFriday,
                Review = "4 stars",
                Image = "2.jpeg"
            },
            new Product
            {
                Id = 3,
                Category = Category.Headphones,
                Name = "JBL 100",
                Description = "New Headphones",
                Price = 100,
                Promotion = true,
                TypeOfPromotion = TypeOfPromotion.CyberMonday,
                Review = "4 stars",
                Image = "3.jpeg"
            },
            new Product
            {
                Id = 4,
                Category = Category.Monitor,
                Name = "LG M6700",
                Description = "New Monitor",
                Price = 200,
                Promotion = false,
                TypeOfPromotion = TypeOfPromotion.None,
                Review = "2 stars",
                Image = "4.jpeg"
            },
            new Product
            {
                Id = 5,
                Category = Category.PC,
                Name = "PC 123",
                Description = "New PC",
                Price = 500,
                Promotion = true,
                TypeOfPromotion = TypeOfPromotion.BlackFriday,
                Review = "5 stars",
                Image = "5.jpeg"
            },
        };

        public static int UserId = 3;
        public static List<User> Users = new List<User>
        {
            new User
            {
                Id = 1,
                FirstName = "Joe",
                LastName = "Black",
                AccountName = "JoeB",
                Address = "Street 1",
                Email = "joeb@gmail.com",
                PhoneNumber = 123456
            },
            new User
            {
                Id = 2,
                FirstName = "Mary",
                LastName = "White",
                AccountName = "MarryW",
                Address = "Street 2",
                Email = "marryw@gmail.com",
                PhoneNumber = 654321
            },
            new User
            {
                Id = 3,
                FirstName = "Ray",
                LastName = "Brown",
                AccountName = "RayB",
                Address = "Street 3",
                Email = "rayb@gmail.com",
                PhoneNumber = 321456
            },
        };

        public static int OrderId = 3;
        public static List<Order> Orders = new List<Order>
        {
            new Order
            {
                Id = 1,
                Delivered = false,
                PaymentMethod = PaymentMethod.Card,
                Price = 100,
                Product = Products.First(),
                User = Users.First()
            },
            new Order
            {
                Id = 2,
                Delivered = true,
                PaymentMethod = PaymentMethod.Card,
                Price = 150,
                Product = Products.First(),
                User = Users.First()
            },
            new Order
            {
                Id = 3,
                Delivered = false,
                PaymentMethod = PaymentMethod.Cash,
                Price = 200,
                Product = Products.First(),
                User = Users.First()
            }
        };
    }
}
