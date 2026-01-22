using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.Responses
{
    public class InstructionScheduleResponse
    {
        public int Id { get; set; }
        public DateTime PlannedDate { get; set; }
        public bool NotificationSent { get; set; }
        public DateTime CreatedAt { get; set; }
        public int EmployeeId { get; set; }
        public int ProgramId { get; set; }
    }
}
