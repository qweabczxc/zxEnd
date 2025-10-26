using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InstructionDocumentEntity
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [MaxLength(255)]
        public string FileName { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string FilePath { get; set; } = string.Empty;

        [Required]
        public DateTime UploadedAt { get; set; } = DateTime.Now;

        // Навигационные свойства
        [ForeignKey("InstructionId")]
        [Required]
        public int InstructionId { get; set; }
        
        public InstructionsEntity Instruction { get; set; } = null!;
    }
}
