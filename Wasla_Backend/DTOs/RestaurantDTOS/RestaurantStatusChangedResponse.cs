namespace Wasla_Backend.DTOs.RestaurantDTOS
{
    public class RestaurantStatusChangedResponse
    {
        public string restaurantId { get; set; }
        public bool isAvailable { get; set; }
    }
}
