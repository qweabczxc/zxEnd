using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InstructionScheduleEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime PlannedDate { get; set; }

        [Required]
        public bool NotificationSent { get; set; } = false;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Навигационные свойства
        [ForeignKey("EmployeeId")]
        [Required]
        public int EmployeeId { get; set; }
        public EmployeeEntity Employee { get; set; } = null!;

        [ForeignKey("ProgramId")]
        [Required]
        public int ProgramId { get; set; }
        public InstructionProgramEntity Program { get; set; } = null!;
    }
}
