using E_Store.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store.Models
{
    public class CyberMondayViewModel
    {
        public int Id { get; internal set; }
        public Category Category { get; internal set; }
        public string Name { get; internal set; }
        public bool Promotion { get; internal set; }
        public TypeOfPromotion TypeOfPromotion { get; internal set; }
        public double Price { get; internal set; }
        public string Description { get; internal set; }
        public string Review { get; internal set; }
        public string Image { get; internal set; }
    }
}
