namespace Wasla_Backend.Services.Interfaces
{
    public interface IBookService
    {
        public Task<List<ServiceBookingDetailsDto>> GetBookingDetailsForUserAsync(string userId, string language);


    }
}
