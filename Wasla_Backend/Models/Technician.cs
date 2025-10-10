namespace Wasla_Backend.Models
{
    public class Technician : ServiceProvider
    {
        public string? Specialty { get; set; } 
        public int ExperienceYears { get; set; }
        public decimal HourlyRate { get; set; }
        public string? AvailableHours { get; set; } 
        public string? ToolsList { get; set; } 
        public string? ServiceArea { get; set; } 
        public string? LicenseNumber { get; set; } 
    }
}
