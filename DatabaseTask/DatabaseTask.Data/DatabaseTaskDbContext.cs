using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<Prison> Prisons { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Cell> Cells { get; set; }
        public DbSet<Prisoner> Prisoners { get; set; }
        public DbSet<CellAssignment> CellAssignments { get; set; }
        public DbSet<Crime> Crimes { get; set; }
        public DbSet<PrisonerCrime> PrisonerCrimes { get; set; }
        public DbSet<Sentence> Sentences { get; set; }
        public DbSet<Guard> Guards { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<GuardShift> GuardShifts { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<Visit> Visits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var fk in modelBuilder.Model.GetEntityTypes()
                         .SelectMany(e => e.GetForeignKeys()))
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}