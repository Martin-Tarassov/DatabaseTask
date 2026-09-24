using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Visit
    {
        [Key]
        public Guid Id { get; set; }

        public Guid PrisonerId { get; set; }
        public Prisoner Prisoner { get; set; } = null!;

        public Guid VisitorId { get; set; }
        public Visitor Visitor { get; set; } = null!;

        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public VisitStatus Status { get; set; }
    }

    public enum VisitStatus
    {
        Planned,
        Completed,
        Cancelled
    }
}
