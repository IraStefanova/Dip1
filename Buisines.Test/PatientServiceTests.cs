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
    public class PatientServiceTests
    {
        private readonly PatientService _patientService;
        public PatientServiceTests()
        {
            var dbContextMock = new Mock<PatientDbContext>();
            dbContextMock.Setup(x => x.Add(It.IsAny<object>()))
                .Returns<object>(null);
            dbContextMock.Setup(x => x.SaveChangesAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(1));
            _patientService = new PatientService(dbContextMock.Object);
        }

        [Test]
        public async Task PatientService_CreatePatient_NoException()
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

            _patientService.CreatePatient(patientDto);
        }
    }
}
