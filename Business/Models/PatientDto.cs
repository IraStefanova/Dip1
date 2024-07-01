using Data.Models;

namespace Business.Models
{
    public class PatientDto
    {
        public int? Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Secname { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public SexEnum Sex { get; set; }
        public string HomeAddres { get; set; }
        public int PhoneNumber { get; set; }
        public int? IdMedicArea { get; set; }
    }
}
