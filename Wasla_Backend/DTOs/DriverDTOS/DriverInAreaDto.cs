namespace Wasla_Backend.DTOs.DriverDTOS
{
    public class DriverInAreaDto
    {
        public string DriverId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public VehicleType VehicleType { get; set; }
        public double DistanceKm { get; set; }
    }
}
