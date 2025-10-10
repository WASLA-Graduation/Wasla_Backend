namespace Wasla_Backend.Models
{
    public class Doctor : ServiceProvider
    {
        public string? Specialization { get; set; }
        public int ExperienceYears { get; set; }
        public decimal ConsultationFee { get; set; }
        public string? AvailableDays { get; set; }
        public string? ClinicPhotos { get; set; } 
        public string? LicenseNumber { get; set; }
        public string? Education { get; set; } 
        public bool InsuranceSupported { get; set; }
        public int AvgConsultationTime { get; set; }
    }
}
