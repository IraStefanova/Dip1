using Business.Models;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mappers
{
    public static class DoctorMapper
    {
        public static DoctorDto MapToDto(Doctors doctors)
        {
            return new DoctorDto
            {
                Id = doctors.Id,
                Name = doctors.Name,
                Secname = doctors.Secname,
                Surname = doctors.Surname,
                DateStartWork = doctors.DateStartWork,
                IdMedicArea = doctors.IdMedicArea
            };
        }

        public static Doctors MapToDb(DoctorDto doctors)
        {
            return new Doctors
            {
                Id = doctors.Id ?? default,
                Name = doctors.Name,
                Secname = doctors.Secname,
                Surname = doctors.Surname,
                DateStartWork = doctors.DateStartWork,
                IdMedicArea = doctors.IdMedicArea ?? 1
            };
        }
    }
}
