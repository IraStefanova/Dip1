using Business.Mappers;
using Business.Models;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class DoctorService(PatientDbContext context) : IDoctorService
    {
        public async Task<List<DoctorDto>> GetDoctors()
        {
            return await context.Doctor.Select(x => DoctorMapper.MapToDto(x)).ToListAsync();
        }

        public async Task CreateDoctor(DoctorDto doctor)
        {
            if (string.IsNullOrEmpty(doctor.Surname))
                throw new Exception("Surname is required");
            if (string.IsNullOrEmpty(doctor.Name))
                throw new Exception("Name is required");

            var doctorEntity = DoctorMapper.MapToDb(doctor);
            context.Doctor.Add(doctorEntity);
            await context.SaveChangesAsync();

        }
        public async Task EditDoctor(DoctorDto doctor)
        {
            var oldValue = await context.Doctor.FirstOrDefaultAsync(t => t.Id == doctor.Id);

            if (oldValue == null)
            {
                throw new Exception("Doctor not found");
            }

            var newValues = DoctorMapper.MapToDb(doctor);
            context.Entry(oldValue).CurrentValues.SetValues(newValues);

            oldValue.Name = doctor.Name;

            await context.SaveChangesAsync();
        }

    }

}
