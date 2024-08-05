using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IDoctorService
    {
        public Task<List<DoctorDto>> GetDoctors();
        public Task CreateDoctor(DoctorDto doctor);
        public Task EditDoctor(DoctorDto doctor);
        public Task DeleteDoctor(DoctorDto doctor);

    }
}
