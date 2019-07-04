using System;
using System.Collections.Generic;
using System.Text;

namespace ABCRestaurant.Data.Entities
{
    public abstract class Entity<T>
    {
        public T Id { get; set; }
    }
}
