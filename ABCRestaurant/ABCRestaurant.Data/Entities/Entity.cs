using System.ComponentModel.DataAnnotations;

namespace ABCRestaurant.Data.Entities
{
    public abstract class Entity<T>
    {
        [Key]
        public T Id { get; set; }
    }
}
