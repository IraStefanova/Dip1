using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IDoctorCallService
    {
        public Task<List<DoctorCallsDto>> GetDoctorCalls();
        public Task CreateDoctorCall(DoctorCallsDto doctorCalls);

        public Task EditDoctorCall(DoctorCallsDto doctorCalls);
        public Task DeleteDoctorCall(DoctorCallsDto doctorCalls);
    }
}
