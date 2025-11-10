namespace Wasla_Backend.Models
{
    public abstract class ServiceProvider : ApplicationUser
    {
        public string? BusinessName { get; set; }
        public string? CV { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string? Description { get; set; } 
        public string? OpeningHours { get; set; } 
        public float Rating { get; set; }
        public int TotalReviews { get; set; }
    }
}
