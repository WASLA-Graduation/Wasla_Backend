
namespace Wasla_Backend.Repositories.Implementation
{
    public class BookingRepository:GenericRepository<Booking>, IBookingRepository
    {
        public BookingRepository(Context context) : base(context)
        {
        }

        public async Task<Booking> GetBookingByServiceDayIdAsync(int serviceDayId)
        {
            return await _context.Booking
                .FirstOrDefaultAsync(b => b.serviceDayId == serviceDayId);
        }

        public async Task<List<ServiceBookingDetailsDto>> GetBookingDetailsForUserAsync(string userId, string language)
        {
            var bookingDetails = await _context.Booking
                .Where(b => b.userId == userId)
                .Include(b => b.serviceDay)
                    .ThenInclude(sd => sd.service)
                        .ThenInclude(s => s.doctor)
                .Select(b => new ServiceBookingDetailsDto
                {
                    id = b.Id,
                    start = b.serviceDay.start,
                    end = b.serviceDay.end,
                    day = b.serviceDay.dayOfWeek.ToString(),
                    date = b.bookingDate.ToString(),

                    ServiceProviderName = b.serviceDay.service.doctor.FullName,
                    ServiceProviderProfilePhoto = b.serviceDay.service.doctor.ProfilePhoto,

                    ServiceName = language.ToLower() == "ar"
                        ? b.serviceDay.service.serviceName.Arabic
                        : b.serviceDay.service.serviceName.English,

                    Price = b.price
                })
                .ToListAsync();

            return bookingDetails;
        }

        public async Task<Booking> GetByServiceDayId(int serviceDayId)
        {
            return await _context.Booking
                .FirstOrDefaultAsync(b => b.serviceDayId == serviceDayId);
        }

        public async Task<bool> GetByUserIdAndDoctorID(string userId, string doctorId)
        {
           return await _context.Booking
                .AnyAsync(b => b.userId == userId && b.serviceProviderId == doctorId);
        }

        public async Task<int> GetNumberOfPatientByDoctorId(string doctorId)
        {
            return await _context.Booking
                    .Where(b => b.serviceProviderId == doctorId
                   && b.serviceProviderType == ServiceProviderType.Doctor)
                  .Select(b => b.userId)
                  .Distinct()
                  .CountAsync();
        }

        
    }
}
