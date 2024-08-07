using Business.Mappers;
using Business.Models;
using Data.Models;

namespace Buisines.Test
{
    public class PatientMapperTests
    {
        [Test]
        public void PatientDtoMap_NoException()
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
                Sex = SexEnum.Male,
                Surname = "Gosling"
            };

            var patientDto = PatientMapper.MapToDto(patientEntity);
        }

        [Test]
        public void PatientDtoToDbMap_NameNotNull()
        {
            var patientDto = new PatientDto
            {
                Id = 1,
                DateOfBirth = new DateOnly(2010, 10, 10),
                HomeAddres = "asdasd",
                IdMedicArea = 1,
                Name = "Ryan",
                PhoneNumber = 375231449,
                Secname = "asdasd",
                Sex = SexEnum.Male,
                Surname = "Gosling"
            };

            var patientEntity = PatientMapper.MapToDb(patientDto);
            Assert.That(string.IsNullOrEmpty(patientEntity.Name), Is.False);
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
                Sex = SexEnum.Male,
                Surname = "Gosling"
            };

            Assert.That(string.IsNullOrEmpty(patientEntity.Name), Is.False);
        }
    }
}