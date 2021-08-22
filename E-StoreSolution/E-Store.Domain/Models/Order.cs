using E_Store.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Store.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public bool Delivered { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
