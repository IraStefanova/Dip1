using Business.Mappers;
using Business.Models;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace Business.Services
{
    public class DoctorCallService(PatientDbContext context) : IDoctorCallService
    {
        public async Task<List<DoctorCallsDto>> GetDoctorCalls()
        {
            return await context.DoctorCalls.Select(x => DoctorCallsMapper.MapToDto(x)).ToListAsync();
        }
        public async Task CreateDoctorCall(DoctorCallsDto doctorCalls)
        {
            if (!await context.Patient.AnyAsync(t => t.Id == doctorCalls.IdPatient))
                throw new Exception("Patient not found");
            if (!await context.Doctor.AnyAsync(t => t.Id == doctorCalls.IdDoctor))
                throw new Exception("Doctor not found");
            if (string.IsNullOrEmpty(doctorCalls.Reason))
                throw new Exception("Reason not found");


            var doctorCallsEntity = DoctorCallsMapper.MapToDb(doctorCalls);
            context.DoctorCalls.Add(doctorCallsEntity);
            await context.SaveChangesAsync();

        }
        public async Task EditDoctorCall(DoctorCallsDto doctorCalls)
        {
            var oldValue = await context.DoctorCalls.FirstOrDefaultAsync(t => t.Id == doctorCalls.Id);

            if (oldValue == null)
            {
                throw new Exception("Call not found");
            }

            var newValues = DoctorCallsMapper.MapToDb(doctorCalls);
            context.Entry(oldValue).CurrentValues.SetValues(newValues);

            oldValue.Reason = doctorCalls.Reason;

            await context.SaveChangesAsync();
        }
        public async Task DeleteDoctorCall(DoctorCallsDto doctorCalls)
        {
            if (doctorCalls.Id == null)
            {
                throw new Exception("DoctorCall id is required");
            }
            var oldValue = await context.DoctorCalls.FirstOrDefaultAsync(t => t.Id == doctorCalls.Id);
            if (oldValue == null)
            {
                throw new Exception("DoctorCall not found");
            }

            context.Remove(oldValue);
            await context.SaveChangesAsync();
        }
    }
}
