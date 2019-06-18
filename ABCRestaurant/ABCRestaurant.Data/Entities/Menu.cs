using System;
using System.Collections.Generic;
using System.Text;

namespace ABCRestaurant.Data.Entities
{
    public class Menu : Entity
    {
        public string MenuName { get; set; }
        public string MenuDescription { get; set; }
        public int Unit { get; set; }
        public double Price { get; set; }
    }
}
