using dotnetcorewebapi.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcorewebapi.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class BaseController<T> : Controller
    {
        private readonly IBaseRepository<T> _repository;
        public BaseController(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }
        
        [HttpPost]
        public IActionResult Create([FromBody] T t) 
        {
            _repository.Add(t);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] T t)
        {
            _repository.Update(t);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok();
        }
    }
}
