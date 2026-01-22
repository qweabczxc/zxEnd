using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.Requests
{
    public class CreateInstructionRequest
    {
        [Required]
        public DateTime InstructionDate { get; set; }

        public DateTime? NextInstructionDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; }

        [Range(0, 100)]
        public decimal? Score { get; set; }

        [MaxLength(100)]
        public string? ProtocolNumber { get; set; }

        public string? Notes { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public int ProgramId { get; set; }

        public List<CreateDocumentRequest>? Documents { get; set; }
    }
}
