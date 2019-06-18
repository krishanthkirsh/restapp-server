using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABCRestaurant.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ABCRestaurant.Data.Repositories;

namespace ABCRestaurent.Api.Controllers
{
    [Route("api/[Order]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }

        [HttpGet]
        public IEnumerable<Order> Get()
        {
            List<Order> _List = this._orderRepository.List().ToList();
            return _List;
        }
        [HttpPost]
        public void InsertOrder(Order order)
        {
            this._orderRepository.Add(order);
        }
    }
}