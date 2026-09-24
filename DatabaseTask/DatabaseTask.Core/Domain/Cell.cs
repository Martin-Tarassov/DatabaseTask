using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Cell
    {
        [Key]
        public Guid Id { get; set; }

        public Guid BlockId { get; set; }
        public Block Block { get; set; } = null!;

        [Required, MaxLength(10)]
        public string Number { get; set; } = null!;

        public int Floor { get; set; }

        public int MaxCapacity { get; set; }

        public ICollection<CellAssignment> CellAssignments { get; set; } = new List<CellAssignment>();
    }
}
