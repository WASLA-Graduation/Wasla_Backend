namespace Wasla_Backend.DTOs.RestaurantDTOS
{
    public class MenuItemRTResponse
    {
        public int id { get; set; }
        public MultilingualText name { get; set; }
        public decimal price { get; set; }
        public string imageUrl { get; set; }
        public bool isAvailable { get; set; }
        public int? categoryId { get; set; }
    }
}
