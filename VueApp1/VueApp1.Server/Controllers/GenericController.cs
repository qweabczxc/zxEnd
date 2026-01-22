using Domain.Abstraction;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VueApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T> : ControllerBase
    {
        private IBaseRepository<T> _repository;

        public GenericController(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public T Create(T entity)
        {
            try
            {
                return _repository.Add(entity);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return entity;
        }
        [HttpPatch]
        public T Update(T model)
        {
            return _repository.Update(model);
        }

        [HttpGet("{id}")]
        public T? Get(int id)
        {
            return _repository.GetById(id);
        }

        [HttpGet]
        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);

            return Ok();
        }
    }
}
