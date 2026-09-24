using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Visitor
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required, MaxLength(20)]
        public string PersonalCode { get; set; } = null!;

        [Required, MaxLength(20)]
        public string PhoneNumber { get; set; } = null!;

        [Required, MaxLength(50)]
        public string Relationship { get; set; } = null!;

        public ICollection<Visit> Visits { get; set; } = new List<Visit>();
    }
}
