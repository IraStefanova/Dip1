using Data.Models;
using Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PatientsController(IPatientService patientService) : ControllerBase
    {
        [HttpGet("GetPatients")]
        public async Task<List<Patients>> GetPatients() => await patientService.GetPatients();

        [HttpGet ("AddPatients")]
        public async Task CreatePatient(Patients patient) => await patientService.CreatePatient(patient);
        
    }
}
