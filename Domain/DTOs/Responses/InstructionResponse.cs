using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.Responses
{
    public class InstructionResponse
    {
        public int Id { get; set; }
        public DateTime InstructionDate { get; set; }
        public DateTime? NextInstructionDate { get; set; }
        public string Status { get; set; }
        public decimal? Score { get; set; }
        public string? ProtocolNumber { get; set; }
        public string? Notes { get; set; }

        public int EmployeeId { get; set; }
        public EmployeeResponse Employee { get; set; }

        public int ProgramId { get; set; }
        public ProgramResponse Program { get; set; }

        public List<DocumentResponse> Documents { get; set; } = new();
    }
}
