namespace Data.Models
{
    public class DoctorCalls
    {
        public int Id { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor  { get; set;}
        public DateOnly DateOfCall { get; set; }
        public string Reason { get; set; }
        public string Result { get; set; }
        public Patients Patients { get; set; }
        public Doctors Doctors { get; set; }


    }
}
