using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InstructionTypeEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string TypeName { get; set; } = string.Empty;

        public string? Description { get; set; }

        public int? ValidityPeriodMonths { get; set; }

        // Навигационные свойства
        public List<InstructionProgramEntity> InstructionPrograms { get; set; } = new();
    }
}
