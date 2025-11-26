using MimeKit.Cryptography;

namespace Wasla_Backend.Services.Implementation
{
    public class BookService: IBookService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IUserRepository _userRepository;
        public BookService(IBookingRepository bookingRepository, IUserRepository userRepository)
        {
            _bookingRepository = bookingRepository;
            _userRepository = userRepository;
        }
        public async Task<List<ServiceBookingDetailsDto>> GetBookingDetailsForUserAsync(string userId, string language)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
            {
                throw new NotFoundException("UserNotFound");
            }
            return await _bookingRepository.GetBookingDetailsForUserAsync(userId, language);
        }
    }
}
