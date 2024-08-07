using Business.Models;
using Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DoctorsController(IDoctorService doctorService) : ControllerBase
    {
        [HttpGet("GetDoctors")]
        public async Task<List<DoctorDto>> GetDoctors() => await doctorService.GetDoctors();

        [HttpPost("AddDoctors")]
        public async Task CreateDoctor(DoctorDto doctor) => await doctorService.CreateDoctor(doctor);

        [HttpPut("EditDoctor")]
        public async Task EditDoctor(DoctorDto doctor) => await doctorService.EditDoctor(doctor);
        
        [HttpDelete("DeleteDoctor")]
        public async Task DeleteDoctor(DoctorDto doctor) => await doctorService.DeleteDoctor(doctor);
    }
}
