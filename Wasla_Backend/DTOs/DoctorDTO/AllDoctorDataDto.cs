namespace Wasla_Backend.DTOs.DoctorDTO
{
    public class AllDoctorDataDto
    {
        public string id { get; set; }
        public string fullName { get; set; }
        public string specialization { get; set; }
        public int experienceYears { get; set; }
        public float rating { get; set; }
        public string universityName { get; set; }
        public double graduationYear { get; set; }
        public string hospitalName { get; set; }
        public int numberOfPatient { get; set; }
       public string birthDay { get; set; }
        public string phone { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string description { get; set; }
        public string imageName { get; set; }
        public string cv { get; set; }
    }
}
