using Business.Models;
using Business.Services;
using Data.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisines.Test
{
    public class PatientValidationTests
    {
        private readonly PatientService _patientService = new PatientService(new Mock<PatientDbContext>().Object);

        [Test]
        public void CreatePatientValidation_NoSurnameException()
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
                Surname = ""
            };

            Assert.ThrowsAsync<Exception>(async () => await _patientService.CreatePatient(patientDto));
        }
    }
}
