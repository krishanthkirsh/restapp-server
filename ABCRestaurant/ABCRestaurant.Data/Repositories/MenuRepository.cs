using ABCRestaurant.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABCRestaurant.Data.Repositories
{
    public class MenuRepository 
        : Repository<Menu> , IMenuRepository
    {
        public MenuRepository(RestaurantDBContext dBContext) 
            :base(dBContext)
        { }
    }
}
