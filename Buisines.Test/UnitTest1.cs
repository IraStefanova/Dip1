using Business.Mappers;
using Data.Models;

namespace Buisines.Test
{
    public class Tests
    {
        [Test]
        public void PatientDtoMap_NoException()
        {
            var patientEntity = new Patients
            {
                Id= 1,
                DateOfBirth = new DateOnly(2010, 10 ,10),
                HomeAddres = "asdasd",
                IdMedicArea = 1,
                Name = "Ryan",
                PhoneNumber = 375231449,
                Secname = "asdasd",
                Sex = "male",
                Surname = "Gosling"
            };

            var patientDto = PatientMapper.MapToDto(patientEntity);
            Assert.Pass();
        }

        [Test]
        public void PatientDtoMap_NameNotNull()
        {
            var patientEntity = new Patients
            {
                Id = 1,
                DateOfBirth = new DateOnly(2010, 10, 10),
                HomeAddres = "asdasd",
                IdMedicArea = 1,
                Name = "Ryan",
                PhoneNumber = 375231449,
                Secname = "asdasd",
                Sex = "male",
                Surname = "Gosling"
            };

            Assert.That(string.IsNullOrEmpty(patientEntity.Name), Is.False);
        }
    }
}