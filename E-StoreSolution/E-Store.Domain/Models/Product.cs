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
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Category Category { get; set; }
        public TypeOfPromotion TypeOfPromotion { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Review { get; set; }
        public bool Promotion { get; set; }
        public string Image { get; set; }
        public List<ProductOrder> ProductOrders { get; set; }
    }
}
