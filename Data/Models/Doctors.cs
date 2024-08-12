namespace Data.Models
{
    public class Doctors
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Secname { get; set; }
        public DateTime DateStartWork { get; set; }
        public int IdMedicArea   { get; set; }
        public MedicAreas MedicAreas { get; set; }
    }
}
