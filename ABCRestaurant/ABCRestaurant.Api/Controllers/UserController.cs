using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABCRestaurant.Data.Entities;
using ABCRestaurant.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ABCRestaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        // GET: api/User
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userRepository.List().ToList();
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public User Get(int id)
        {
            return _userRepository.FindById(id);
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] User Obj)
        {
            _userRepository.Add(Obj);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User Obj)
        {
            _userRepository.Update(Obj);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(User Obj)
        {
            _userRepository.Delete(Obj);
        }
    }
}
