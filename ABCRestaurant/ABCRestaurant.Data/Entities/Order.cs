using System;
using System.Collections.Generic;
using System.Text;

namespace ABCRestaurant.Data.Entities
{
    public class Order 
        : Entity<int>
    {
        public string OrderDate { get; set; }
        public int ? MenuId { get; set; }
        public int ? UserId { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual User User { get; set; }
    }
}
