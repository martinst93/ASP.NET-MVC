using E_Store.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Store.Domain.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public bool Delivered { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public List<ProductOrder> ProductOrders { get; set; } = new List<ProductOrder>();
    }
}
