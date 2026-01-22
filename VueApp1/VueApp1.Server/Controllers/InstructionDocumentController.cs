using Domain.Abstraction;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VueApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructionDocumentController : GenericController<InstructionDocumentEntity>
    {
        public InstructionDocumentController(IBaseRepository<InstructionDocumentEntity> repository) : base(repository)
        {
        }
    }
}
