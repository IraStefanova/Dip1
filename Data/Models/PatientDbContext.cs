using Microsoft.EntityFrameworkCore;

namespace Data.Models
{
    public class PatientDbContext(DbContextOptions<PatientDbContext> options) : DbContext(options)
    {
        public PatientDbContext() : this(new DbContextOptions<PatientDbContext>()) { }

        public DbSet<Patients> Patient { get; set; }
        public DbSet<Doctors> Doctor { get; set; }
        public DbSet<DoctorCalls> DoctorCalls { get; set; }
        public DbSet<MedicAreas> MedicAreas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PatientDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }


    }
}
