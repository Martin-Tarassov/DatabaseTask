using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Prisoner
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; } = null!;

        [Required, MaxLength(50)]
        public string LastName { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        [Required, MaxLength(20)]
        public string PersonalCode { get; set; } = null!;

        public DateTime ArrivalDate { get; set; }

        public PrisonerStatus Status { get; set; }

        public ICollection<CellAssignment> CellAssignments { get; set; } = new List<CellAssignment>();
        public ICollection<PrisonerCrime> PrisonerCrimes { get; set; } = new List<PrisonerCrime>();
        public ICollection<Sentence> Sentences { get; set; } = new List<Sentence>();
        public ICollection<Visit> Visits { get; set; } = new List<Visit>();

        
    }
    public enum PrisonerStatus
    {
        Active,
        Released,
        Transferred
    }
}
