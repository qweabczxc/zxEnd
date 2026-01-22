using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VueApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructionProgramController : GenericController<InstructionProgramEntity>
    {
        public InstructionProgramController(Domain.Abstraction.IBaseRepository<InstructionProgramEntity> repository) : base(repository)
        {
        }
    }
}
