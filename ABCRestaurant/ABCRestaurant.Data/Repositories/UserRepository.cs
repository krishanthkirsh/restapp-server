using ABCRestaurant.Data.Entities;

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
