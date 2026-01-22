using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.Responses
{
    public class InstructionTypeResponse
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public int ValidityPeriodMonths { get; set; }
    }
}
