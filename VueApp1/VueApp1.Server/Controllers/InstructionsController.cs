using AutoMapper;
using DAL;
using Domain.Abstraction;
using Domain.DTOs.Requests;
using Domain.DTOs.Responses;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace VueApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructionsController : GenericController<InstructionsEntity>
    {
        public InstructionsController(IBaseRepository<InstructionsEntity> repository) : base(repository)
        {
        }
    }
}
