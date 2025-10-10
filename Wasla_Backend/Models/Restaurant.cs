namespace Wasla_Backend.Models
{
    public class Restaurant : ServiceProvider
    {
        public string? CuisineType { get; set; } 
        public string? MenuItemsJson { get; set; } 
        public int AverageDeliveryTime { get; set; }
        public decimal MinOrderValue { get; set; }
        public bool DeliveryAvailable { get; set; }
        public decimal DeliveryFee { get; set; }
        public string? PaymentMethods { get; set; } 
    }
}
