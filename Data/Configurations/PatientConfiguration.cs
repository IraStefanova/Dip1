using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patients>
    {
        public void Configure(EntityTypeBuilder<Patients> entity)
        {
            entity.HasKey(t => t.Id);
            entity.Property(t => t.Surname).IsRequired();
            entity.Property(t => t.Name).IsRequired();
            entity.Property(t => t.Secname);
            entity.Property(t => t.DateOfBirth).IsRequired();
            entity.Property(t => t.Sex).IsRequired();
            entity.Property(t => t.HomeAddres);
            entity.Property(t => t.PhoneNumber).IsRequired();
            entity.HasOne(t => t.MedicAreas).WithMany().HasForeignKey(t => t.IdMedicArea);
        }

    }
}
