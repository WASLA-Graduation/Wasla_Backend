namespace Wasla_Backend.Models
{
    public class Driver : ServiceProvider
    {
        public string? VehicleType { get; set; } 
        public string? VehicleModel { get; set; } 
        public string? VehicleNumber { get; set; } 
        public string? LicenseNumber { get; set; } 
        public int DrivingExperienceYears { get; set; }
        public bool IsAvailable { get; set; } = true;
        public float CurrentLatitude { get; set; }
        public float CurrentLongitude { get; set; }
    }
}
