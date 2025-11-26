namespace Wasla_Backend.DTOs.BookDTOS
{
    public class ServiceBookingDetailsDto
    {
        public string TimeSlot { get; set; }
        public string Day { get; set; }
        public string ServiceProviderName { get; set; }
        public string ServiceProviderProfilePhoto { get; set; }
        public string ServiceName { get; set; }
        public double Price { get; set; }
        public bool IsConfirmed { get; set; }
    }
}
