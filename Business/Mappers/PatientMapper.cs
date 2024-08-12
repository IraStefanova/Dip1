using Business.Models;
using Data.Models;

namespace Business.Mappers
{
    public static class PatientMapper
    {
        public static PatientDto MapToDto(Patients patients)
        {
            return new PatientDto
            {
                Id = patients.Id,
                Name = patients.Name,
                DateOfBirth = patients.DateOfBirth,
                HomeAddres = patients.HomeAddres,
                PhoneNumber = patients.PhoneNumber,
                Secname = patients.Secname,
                Sex = patients.Sex,
                Surname = patients.Surname
            };
        }

        public static Patients MapToDb(PatientDto patients)
        {
            return new Patients
            {
                Id = patients.Id ?? default,
                Name = patients.Name,
                DateOfBirth = patients.DateOfBirth,
                HomeAddres = patients.HomeAddres,
                PhoneNumber = patients.PhoneNumber,
                Secname = patients.Secname,
                Sex = patients.Sex,
                Surname = patients.Surname,
                IdMedicArea = patients.IdMedicArea ?? 1
            };
        }
    }
}
