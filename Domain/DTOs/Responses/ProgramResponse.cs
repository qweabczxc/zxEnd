using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.Responses
{
    public class ProgramResponse
    {
        public int Id { get; set; }
        public string ProgramName { get; set; }
        public int Version { get; set; }
        public string Content { get; set; }
        public int DurationMinutes { get; set; }

        public int InstructionTypeId { get; set; }
        public InstructionTypeResponse InstructionType { get; set; }

        public List<InstructionScheduleResponse> InstructionSchedules { get; set; } = new();
    }
}
