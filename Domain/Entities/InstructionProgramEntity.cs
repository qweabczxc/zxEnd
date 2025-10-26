using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InstructionProgramEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string ProgramName { get; set; } = string.Empty;

        [Required]
        public int Version { get; set; } = 1;

        public string? Content { get; set; }

        public int? DurationMinutes { get; set; }

        // Навигационные свойства
        [ForeignKey("InstructionTypeId")]
        public int InstructionTypeId { get; set; }
        public InstructionTypeEntity InstructionType { get; set; } = null!;

        public List<InstructionsEntity> Instructions { get; set; } = new();
        public List<InstructionScheduleEntity> InstructionSchedules { get; set; } = new();
    }
}
