using System;
using System.Collections.Generic;
using System.Text;

namespace ABCRestaurant.Data.Entities
{
    public class Menu 
        : Entity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
