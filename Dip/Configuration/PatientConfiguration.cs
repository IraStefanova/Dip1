using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Configuration
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patients>
    {
        public void Configure(EntityTypeBuilder<Patients> entity)
        {
            entity.HasKey(t => t.Id);

        }

    }
}
