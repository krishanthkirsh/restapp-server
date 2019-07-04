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
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return _userRepository.List().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return _userRepository.FindById(id);
        }

        [HttpPost]
        public void Post(User Obj)
        {
            _userRepository.Add(Obj);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User Obj)
        {
            _userRepository.Update(Obj);
        }

        [HttpDelete("{id}")]
        public void Delete(User Obj)
        {
            _userRepository.Delete(Obj);
        }
    }
}
