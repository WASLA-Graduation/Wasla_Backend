
namespace Wasla_Backend.Repositories.Interfaces
{
    public interface IBookingRepository : IGenericRepository<Booking>
    {
        public Task<List<ServiceBookingDetailsDto>> GetBookingDetailsForUserAsync(string userId, string language);
        public Task<Booking> GetBookingByServiceDayIdAsync(int serviceDayId);
        public Task<int>GetNumberOfPatientByDoctorId(string doctorId);
        public Task<Booking>GetByServiceDayId(int serviceDayId);
        public Task<bool>GetByUserIdAndDoctorID(string userId, string doctorId);
    }
}
