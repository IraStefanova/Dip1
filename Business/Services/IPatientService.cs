using Business.Models;

namespace Business.Services
{
    public interface IPatientService
    {
        public Task<List<PatientDto>> GetPatients();
        public Task CreatePatient(PatientDto patient);
        public Task EditPatient(PatientDto patient);
    }
}
