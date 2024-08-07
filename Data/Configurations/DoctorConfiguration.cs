using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctors>
    {
        public void Configure(EntityTypeBuilder<Doctors> entity)
        {
            entity.HasKey(t => t.Id);
            entity.Property(t => t.Surname).IsRequired();
            entity.Property(t => t.Name).IsRequired();
            entity.Property(t => t.Secname);
            entity.HasOne(t => t.MedicAreas).WithMany().HasForeignKey(t => t.IdMedicArea);
        }
    }
}
