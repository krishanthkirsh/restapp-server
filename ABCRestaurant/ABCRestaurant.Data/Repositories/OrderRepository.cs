using ABCRestaurant.Data;
using ABCRestaurant.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

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
