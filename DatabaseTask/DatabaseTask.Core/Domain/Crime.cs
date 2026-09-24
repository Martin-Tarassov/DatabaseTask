using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Crime
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public CrimeSeverity Severity { get; set; }

        public ICollection<PrisonerCrime> PrisonerCrimes { get; set; } = new List<PrisonerCrime>();
        public ICollection<Sentence> Sentences { get; set; } = new List<Sentence>();
    }

    public enum CrimeSeverity
    {
        Minor,
        Serious,
        Severe
    }
}
