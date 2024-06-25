using Data.Models;

namespace Business.Services
{
    public interface IPatientService
    {
        public Task<List<Patients>> GetPatients();
        public Task CreatePatient(Patients patient);
    }
}
