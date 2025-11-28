namespace Wasla_Backend.DTOs.ServiceDTOS
{
    public class ServiceDayResponse
    {
        public int id { get; set; }
        public int dayOfWeek { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public bool isBooking { get; set; } = false;
    }
}
