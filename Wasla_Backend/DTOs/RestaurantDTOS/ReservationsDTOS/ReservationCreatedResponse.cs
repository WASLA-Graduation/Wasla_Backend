namespace Wasla_Backend.DTOs.RestaurantDTOS
{
    public class ReservationCreatedResponse
    {
        public int reservationId { get; set; }

        public Status status { get; set; }

        public DateOnly reservationDate { get; set; }

        public TimeOnly reservationTime { get; set; }

        public int numberOfPersons { get; set; }
    }
}
