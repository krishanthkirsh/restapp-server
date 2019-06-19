using ABCRestaurant.Data.Entities;

namespace ABCRestaurant.Data.Repositories
{
    public class MenuRepository
        : Repository<Menu>, IMenuRepository
    {
        public MenuRepository(RestaurantDBContext dBConn)
            : base(dBConn)
        { }
    }
}
