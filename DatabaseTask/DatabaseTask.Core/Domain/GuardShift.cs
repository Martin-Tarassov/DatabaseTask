using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class GuardShift
    {
        [Key]
        public Guid Id { get; set; }

        public Guid GuardId { get; set; }
        public Guard Guard { get; set; } = null!;

        public Guid ShiftId { get; set; }
        public Shift Shift { get; set; } = null!;
    }
}
