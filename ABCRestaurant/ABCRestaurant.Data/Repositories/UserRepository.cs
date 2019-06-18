using ABCRestaurant.Data;
using ABCRestaurant.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABCRestaurant.Data.Repositories
{
    public class UserRepository 
        : Repository<User> ,IUserRepository
    {
        public UserRepository(RestaurantDBContext dBConn) 
            : base(dBConn)
        { }
    }
}
