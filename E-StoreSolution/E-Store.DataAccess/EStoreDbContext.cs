using E_Store.Domain.Enums;
using E_Store.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Store.DataAccess
{
    public class EStoreDbContext : DbContext
    {
        public EStoreDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
               .HasMany(x => x.ProductOrders)
               .WithOne(x => x.Order)
               .HasForeignKey(x => x.OrderId);

            modelBuilder.Entity<Product>()
                .HasMany(x => x.ProductOrders)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            #region SeedUser
            modelBuilder.Entity<User>()
                .HasData(
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
                    }
                );
            #endregion

            #region SeedProduct
            modelBuilder.Entity<Product>()
                .HasData(
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
                    }
                );
            #endregion

            #region SeedOrder
                modelBuilder.Entity<Order>()
                    .HasData(
                    new Order
                    {
                        Id = 1,
                        Delivered = false,
                        PaymentMethod = PaymentMethod.Card,
                        Price = 100,
                        UserId = 1
                    },
                    new Order
                    {
                        Id = 2,
                        Delivered = true,
                        PaymentMethod = PaymentMethod.Card,
                        Price = 150,
                        UserId = 2
                    },
                    new Order
                    {
                        Id = 3,
                        Delivered = false,
                        PaymentMethod = PaymentMethod.Cash,
                        Price = 200,
                        UserId = 3
                    }
                );
            #endregion
        }
    }
}
