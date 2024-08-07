using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    internal class DoctorCallsConfiguration : IEntityTypeConfiguration<DoctorCalls>
    {
        public void Configure(EntityTypeBuilder<DoctorCalls> entity)
        {
            entity.HasKey(t => t.Id);
            entity.HasOne(t => t.Patients).WithMany().HasForeignKey(t => t.IdPatient).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(t => t.Doctors).WithMany().HasForeignKey(t => t.IdDoctor).OnDelete(DeleteBehavior.NoAction);
            entity.Property(t => t.DateOfCall).IsRequired();
            entity.Property(t => t.Reason).IsRequired();
            entity.Property(t => t.Result).IsRequired();

        }
    }
}
