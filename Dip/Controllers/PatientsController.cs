using Data.Models;
using Business.Services;
using Microsoft.AspNetCore.Mvc;
using Business.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PatientsController(IPatientService patientService) : ControllerBase
    {
        [HttpGet("GetPatients")]
        public async Task<List<PatientDto>> GetPatients() => await patientService.GetPatients();

        [HttpPost("AddPatients")]
        public async Task CreatePatient(PatientDto patient) => await patientService.CreatePatient(patient);
       
        [HttpPut("EditPatient")]
        public async Task EditPatient(PatientDto patient) => await patientService.EditPatient(patient);


        [HttpDelete("DeletePatient")]
        public async Task DeletePatient(PatientDto patient) => await patientService.DeletePatient(patient);
    }
}
