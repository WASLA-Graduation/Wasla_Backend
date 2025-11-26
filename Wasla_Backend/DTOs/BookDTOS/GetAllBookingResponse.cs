namespace Wasla_Backend.DTOs.BookDTOS
{
    public class GetAllBookingResponse
    {
        public int bookingId { get; set; }
        public string serviceName { get; set; }
        public string userName { get; set; }
        public string userImage { get; set; }
        public string date { get; set; }
        public string timeSlot { get; set; }
        public string bookingType { get; set; }
        public List<string>? bookingImages { get; set; }
    }
}
