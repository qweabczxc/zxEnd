using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InstructionsEntity
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public DateTime InstructionDate { get; set; } = DateTime.Now;

        public DateTime NextInstructionDate { get; set; }

        [Required]
        [MaxLength(20)]
        public string Status { get; set; } = "Планируется";

        [Column(TypeName = "decimal(5,2)")]
        public decimal? Score { get; set; }

        [MaxLength(50)]
        public string? ProtocolNumber { get; set; }

        public string? Notes { get; set; }

        // Навигационные свойства
        [ForeignKey("EmployeeId")]
        [Required]
        public int EmployeeId { get; set; }



        public EmployeeEntity? Employee { get; set; } = null!;

        [ForeignKey("ProgramId")]
        [Required]
        public int ProgramId { get; set; }
        
        public InstructionProgramEntity? Program { get; set; } = null!;

        public List<InstructionDocumentEntity> Documents { get; set; } = new();
    }
}
