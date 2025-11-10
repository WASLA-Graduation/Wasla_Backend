namespace Wasla_Backend.Models
{
    public class Doctor : ServiceProvider
    {
        public int ExperienceYears { get; set; }
        public string? UniversityName { get; set; }
        public double GraduationYear { get; set; }
        public decimal ConsultationFee { get; set; }
        public string? AvailableDays { get; set; }
        public string? ClinicPhotos { get; set; } 
        public string? LicenseNumber { get; set; }
        public string? Education { get; set; } 
        public bool InsuranceSupported { get; set; }
        public int AvgConsultationTime { get; set; }
        public DoctorSpecialization? Specialization { get; set; }

        [ForeignKey("Specialization")]
        public int? SpecializationId { get; set; }
    }
}
