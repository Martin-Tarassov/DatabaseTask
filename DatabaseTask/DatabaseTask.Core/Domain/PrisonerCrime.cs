using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class PrisonerCrime
    {
        [Key]
        public Guid Id { get; set; }

        public Guid PrisonerId { get; set; }
        public Prisoner Prisoner { get; set; } = null!;

        public Guid CrimeId { get; set; }
        public Crime Crime { get; set; } = null!;
    }
}
