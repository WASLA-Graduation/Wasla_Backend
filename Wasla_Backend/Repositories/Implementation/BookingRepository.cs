
namespace Wasla_Backend.Repositories.Implementation
{
    public class BookingRepository:GenericRepository<Booking>, IBookingRepository
    {
        public BookingRepository(Context context) : base(context)
        {
        }

        public async Task<List<ServiceBookingDetailsDto>> GetBookingDetailsForUserAsync(string userId, string language)
        {
            var bookingDetails = await _context.Booking
                .Where(b => b.UserId == userId)
                .Include(b => b.Service)
                .Join(
                    _context.Users,
                    booking => booking.ServiceProviderId,
                    user => user.Id,
                    (booking, serviceProvider) => new { booking, serviceProvider }
                )
                .Select(joined => new ServiceBookingDetailsDto
                {
                    TimeSlot = joined.booking.TimeSlot,
                    Day = joined.booking.Day,
                    Price = joined.booking.Price,
                    IsConfirmed = joined.booking.IsConfirmed,

                    ServiceProviderName = joined.serviceProvider.FullName,
                    ServiceProviderProfilePhoto = joined.serviceProvider.ProfilePhoto ?? string.Empty,
                    ServiceName = language.ToLower() == "ar" ?
                                  joined.booking.Service.serviceName.Arabic :
                                  joined.booking.Service.serviceName.English
                })
                .ToListAsync();

            return bookingDetails;
        }
    }
}
