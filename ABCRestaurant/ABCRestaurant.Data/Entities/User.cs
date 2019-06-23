using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCRestaurant.Data.Entities
{
    public class User : Entity<int>
    {
        public string UserName { get; set; }
    }
}
