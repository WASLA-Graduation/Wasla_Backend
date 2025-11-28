
namespace Wasla_Backend.Repositories.Interfaces
{
    public interface IBookingRepository : IGenericRepository<Booking>
    {
        public Task<List<ServiceBookingDetailsDto>> GetBookingDetailsForUserAsync(string userId, string language);
        public Task<Booking> GetBookingByServiceDayIdAsync(int serviceDayId);
    }
}
