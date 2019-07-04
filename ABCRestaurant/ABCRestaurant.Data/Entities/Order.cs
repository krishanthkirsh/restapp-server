using System;
using System.Collections.Generic;
using System.Text;

namespace ABCRestaurant.Data.Entities
{
    public class Order 
        : Entity<int>
    {
        public string OrderDate { get; set; }
        public virtual Menu MenuItem { get; set; }
        public virtual User ProfileUser { get; set; }
    }
}
