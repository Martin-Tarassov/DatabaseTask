using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Prison
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required, MaxLength(100)]
        public string Location { get; set; } = null!;

        public int MaxCapacity { get; set; }

        public ICollection<Block> Blocks { get; set; } = new List<Block>();
    }
}
