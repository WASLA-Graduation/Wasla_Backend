namespace Wasla_Backend.DTOs.DoctorDTO
{
    public class CollectedPricePerYearDto
    {
        public int year { get; set; }
        public List<CollectedPricePerMonthDto> months { get; set; }
    }
}
