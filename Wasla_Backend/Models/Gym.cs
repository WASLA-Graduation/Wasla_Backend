namespace Wasla_Backend.Models
{
    public class Gym : ServiceProvider
    {
        public string? MembershipPlansJson { get; set; } 
        public string? Facilities { get; set; } 
        public int TrainerCount { get; set; }
        public string? ClassScheduleJson { get; set; }
        public int MaxCapacity { get; set; }
        public decimal? DayPassPrice { get; set; }
    }
}
