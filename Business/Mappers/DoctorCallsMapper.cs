using Business.Models;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mappers
{
    public static class DoctorCallsMapper
    {
        public static DoctorCallsDto MapToDto (DoctorCalls doctorCalls)
        {
            return new DoctorCallsDto
            {
                Id = doctorCalls.Id,
                IdPatient = doctorCalls.IdPatient,
                IdDoctor = doctorCalls.IdDoctor,
                DateOfCall = doctorCalls.DateOfCall,
                Reason = doctorCalls.Reason,
                Result = doctorCalls.Result
            };
        }
        public static DoctorCalls MapToDb(DoctorCallsDto doctorCalls)
        {
            return new DoctorCalls
            {
                Id = doctorCalls.Id ?? default,
                IdPatient = doctorCalls.IdPatient ?? 1,
                IdDoctor = doctorCalls.IdDoctor ?? 2,
                DateOfCall = doctorCalls.DateOfCall,
                Reason = doctorCalls.Reason,
                Result = doctorCalls.Result
            };
        }
    }
}
