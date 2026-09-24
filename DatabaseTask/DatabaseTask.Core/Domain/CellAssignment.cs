using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class CellAssignment
    {
        [Key]
        public Guid Id { get; set; }

        public Guid PrisonerId { get; set; }
        public Prisoner Prisoner { get; set; } = null!;

        public Guid CellId { get; set; }
        public Cell Cell { get; set; } = null!;

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
