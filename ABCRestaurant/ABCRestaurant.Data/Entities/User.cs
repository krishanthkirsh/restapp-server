using System;
using System.Collections.Generic;
using System.Text;

namespace ABCRestaurant.Data.Entities
{
    public class User 
        : Entity<int>
    {
        public string UserName { get; set; }
    }
}
