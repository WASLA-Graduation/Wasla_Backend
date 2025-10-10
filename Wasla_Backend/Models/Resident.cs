namespace Wasla_Backend.Models
{
    public class Resident : ApplicationUser
    {
        public string? NationalId { get; set; } 
        public DateTime? DateOfBirth { get; set; }
        public string? Location { get; set; } 

    }
}
