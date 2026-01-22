using Domain.Abstraction;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VueApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructionScheduleController : GenericController<InstructionScheduleEntity>
    {
        public InstructionScheduleController(IBaseRepository<InstructionScheduleEntity> repository) : base(repository)
        {
        }
    }
}
