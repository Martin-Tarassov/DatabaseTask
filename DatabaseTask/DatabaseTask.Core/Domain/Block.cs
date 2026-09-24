using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Block
    {
        [Key]
        public Guid Id { get; set; }

        public Guid PrisonId { get; set; }
        public Prison Prison { get; set; } = null!;

        [Required, MaxLength(10)]
        public string Number { get; set; } = null!;

        [Required, MaxLength(50)]
        public string Name { get; set; } = null!;

        [Required, MaxLength(20)]
        public string SecurityLevel { get; set; } = null!;

        public ICollection<Cell> Cells { get; set; } = new List<Cell>();
    }
}
