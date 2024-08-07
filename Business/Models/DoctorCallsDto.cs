using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class DoctorCallsDto
    {
        public int? Id { get; set; }
        public int? IdPatient { get; set; }
        public int? IdDoctor { get; set; }
        public DateOnly DateOfCall { get; set; }
        public string Reason { get; set; }
        public string Result { get; set; }
    }
}
