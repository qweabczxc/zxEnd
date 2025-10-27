using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AppDBContext : DbContext
    {

        DbSet<EmployeeEntity> employeeEntities {  get; set; }
        DbSet<InstructionDocumentEntity> instructionDocumentEntities { get; set; }
        DbSet<InstructionProgramEntity> instructionProgramEntities { get; set; }
        DbSet<InstructionScheduleEntity> instructionScheduleEntities { get; set; }
        DbSet<InstructionsEntity> instructionsEntities { get; set; }
        DbSet<InstructionTypeEntity> instructionTypeEntities { get; set; }

        public AppDBContext(DbContextOptions options) : base(options)
        {
        }

    }
}
