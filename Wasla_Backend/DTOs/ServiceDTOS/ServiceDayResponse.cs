namespace Wasla_Backend.DTOs.ServiceDTOS
{
    public class ServiceDayResponse
    {
        public int dayOfWeek { get; set; }
        public List<SlotsResonse> timeSlots { get; set; }
    }
}
