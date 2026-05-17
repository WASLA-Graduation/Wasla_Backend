namespace Wasla_Backend.DTOs.RestaurantDTOS
{
    public class ReservationStatusChangedResponse
    {
        public int reservationId { get; set; }

        public Status status { get; set; }
    }   
}
