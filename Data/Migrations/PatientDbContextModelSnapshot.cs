using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace WebApi.Migrations
{


    [DbContext(typeof(PatientDbContext))]
    public class PatientDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            modelBuilder.UseIdentityColumns();

            modelBuilder.Entity("Dip.Models.Patients", b =>
            {
                b.Property<int>("Id")
                    .HasColumnType("int");

                b.Property<string>("Surname")
                    .HasColumnType("string");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("string");

                b.Property<string>("Secname")
                    .HasColumnType("string");

                b.Property<DateOnly>("DateOfBirth")
                    .HasColumnType("DateOnly");

                b.Property<string>("Sex")
                    .IsRequired()
                    .HasColumnType("string");

                b.Property<string>("HomeAddres")
                    .HasColumnType("string");

                b.Property<int>("PhoneNumber")
                    .IsRequired()
                    .HasColumnType("int");

                b.Property<int>("IdMedicArea")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("Patients");
            });
        }

    }
}
