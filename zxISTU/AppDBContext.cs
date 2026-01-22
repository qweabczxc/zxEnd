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

        public DbSet<EmployeeEntity> employeeEntities {  get; set; }
        public DbSet<InstructionDocumentEntity> instructionDocumentEntities { get; set; }
        public DbSet<InstructionProgramEntity> instructionProgramEntities { get; set; }
        public DbSet<InstructionScheduleEntity> instructionScheduleEntities { get; set; }
        public DbSet<InstructionsEntity> instructionsEntities { get; set; }
        public DbSet<InstructionTypeEntity> instructionTypeEntities { get; set; }

        public AppDBContext(DbContextOptions options) : base(options)
        {
        }

    }
}
