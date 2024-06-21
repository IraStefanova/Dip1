using Data.Models;

namespace Business.Services
{
    public class PatientService(PatientDbContext context) : IPatientService
    {
        public async Task CreatePatient(Patients patient)
        {
            context.Patient.Add(patient);
            await context.SaveChangesAsync();
        }

        public Task<List<Patients>> GetPatients()
        {
            throw new NotImplementedException();
        }
    }
}
