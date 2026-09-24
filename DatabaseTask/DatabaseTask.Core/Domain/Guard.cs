using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Guard
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; } = null!;

        [Required, MaxLength(50)]
        public string LastName { get; set; } = null!;

        [Required, MaxLength(20)]
        public string EmployeeNumber { get; set; } = null!;

        [Required, MaxLength(50)]
        public string Position { get; set; } = null!;

        public ICollection<GuardShift> GuardShifts { get; set; } = new List<GuardShift>();
    }
}
