namespace Wasla_Backend.DTOs.DriverDTOS
{
    public class LocationDto
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public VehicleType VehicleType { get; set; } = VehicleType.Car;
    }
}
