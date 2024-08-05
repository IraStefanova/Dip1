using Business.Mappers;
using Business.Models;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Business.Services
{

    public class PatientService(PatientDbContext context) : IPatientService
    {
        public async Task<List<PatientDto>> GetPatients()
        {
            return await context.Patient.Select(x => PatientMapper.MapToDto(x)).ToListAsync();
        }
        public async Task CreatePatient(PatientDto patient)
        {
            if (string.IsNullOrEmpty(patient.Surname))
                throw new Exception("Surname is required");
            if (string.IsNullOrEmpty(patient.Name))
                throw new Exception("Name is required");
            if (DateTime.Now.Year - patient.DateOfBirth.Year > ConstValues.MaxAge)
                throw new Exception("You are too old for this");

            var patientEntity = PatientMapper.MapToDb(patient);
            context.Patient.Add(patientEntity);
            await context.SaveChangesAsync();
        }
        
        public async Task EditPatient(PatientDto patient)
        {
            var oldValue = await context.Patient.FirstOrDefaultAsync(t => t.Id == patient.Id);

            if (oldValue == null)
            {
                throw new Exception("Patient not found");
            }

            var newValues = PatientMapper.MapToDb(patient);
            context.Entry(oldValue).CurrentValues.SetValues(newValues);

            oldValue.Name = patient.Name;

            await context.SaveChangesAsync();
        }
    }
}
