using ABCRestaurant.Data.Entities;
using ABCRestaurant.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ABCRestaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuRepository _menuRepository;

        public MenuController(IMenuRepository menuRepository)
        {
            this._menuRepository = menuRepository;
        }

        // GET: api/Menu
        [HttpGet]
        public IEnumerable<Menu> Get()
        {
            return _menuRepository.List().ToList();
        }

        // GET: api/Menu/5
        [HttpGet("{id}", Name = "Get")]
        public Menu Get(int id)
        {
            return _menuRepository.FindById(id);
        }

        // POST: api/Menu
        [HttpPost]
        public void Post([FromBody] Menu Obj)
        {
            _menuRepository.Add(Obj);
        }

        // PUT: api/Menu/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Menu Obj)
        {
            _menuRepository.Update(Obj);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(Menu Obj)
        {
            _menuRepository.Delete(Obj);
        }
    }
}
