using Business.Models;
using Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DoctorCallController (IDoctorCallService doctorCallService) : ControllerBase
    {
        [HttpGet("GetDoctorCalls")]
        public async Task<List<DoctorCallsDto>> GetDoctorCalls() => await doctorCallService.GetDoctorCalls();

        [HttpPost("CreateDoctorCall")]
        public async Task CreateDoctorCall(DoctorCallsDto doctorCalls) => await doctorCallService.CreateDoctorCall(doctorCalls);

        [HttpPut("EditDoctor")]
        public async Task EditDoctorCall(DoctorCallsDto doctorCalls) => await doctorCallService.EditDoctorCall(doctorCalls);

    }
}
