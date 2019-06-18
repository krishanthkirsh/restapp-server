using ABCRestaurant.Data.Entities;

namespace ABCRestaurant.Data.Repositories
{
    public class OrderRepository 
        : Repository<Order> , IOrderRepository
    {
        public OrderRepository(RestaurantDBContext dBConn) 
            : base(dBConn)
        { }
    }
}
