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
    internal class MedicAreaConfiguration : IEntityTypeConfiguration<MedicAreas>
    {
        public void Configure(EntityTypeBuilder<MedicAreas> entity)
        {
            entity.HasKey(t => t.Id);
            entity.Property(t => t.Name).IsRequired();
        }
    }
}
