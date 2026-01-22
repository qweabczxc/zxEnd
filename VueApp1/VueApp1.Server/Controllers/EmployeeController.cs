using Domain.Abstraction;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VueApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : GenericController<EmployeeEntity>
    {
        public EmployeeController(IBaseRepository<EmployeeEntity> repository) : base(repository)
        {
        }
    }
}
