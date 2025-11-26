namespace Wasla_Backend.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public String UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public int ServiceId { get; set; }

        [ForeignKey("ServiceId")]
        public Service Service { get; set; }
        public string ServiceProviderId { get; set; }

        public double Price { get; set; }
        public ServiceProviderType ServiceProviderType { get; set; }
        public DateTime BookingDate { get; set; } = DateTime.Now;
        public BookingType BookingType { get; set; }
        public string TimeSlot { get; set; }
        public string Day { get; set; }
        public bool IsConfirmed { get; set; } = false;

        public string? ImagesJson { get; set; }

        [NotMapped]
        public List<string> Images
        {
            get => ImagesJson == null ? new List<string>() : JsonSerializer.Deserialize<List<string>>(ImagesJson);
            set => ImagesJson = JsonSerializer.Serialize(value);
        }
    }
}
