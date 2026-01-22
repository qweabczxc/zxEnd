using Domain.Abstraction;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VueApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructionTypeController : GenericController<InstructionTypeEntity>
    {
        public InstructionTypeController(IBaseRepository<InstructionTypeEntity> repository) : base(repository)
        {
        }
    }
}
