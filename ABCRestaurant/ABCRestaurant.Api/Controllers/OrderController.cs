using ABCRestaurant.Data.Entities;
using ABCRestaurant.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABCRestaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            List<Order> _List = this._orderRepository.List().ToList();
            return _List;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            return this._orderRepository.FindById(id);
        }

        // POST: api/Order
        [HttpPost]
        public void Post(Order Obj)
        {
            this._orderRepository.Add(Obj);
        }

        // PUT: api/Order/5
        [HttpPut("{id}")]
        public void Put(int id, Order Obj)
        {
            this._orderRepository.Update(Obj);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public void Delete(Order obj)
        {
            this._orderRepository.Delete(obj);
        }
    }
}
