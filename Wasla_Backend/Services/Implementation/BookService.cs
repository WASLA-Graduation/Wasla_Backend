using Microsoft.AspNetCore.Hosting;
using MimeKit.Cryptography;

namespace Wasla_Backend.Services.Implementation
{
    public class BookService: IBookService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IUserRepository _userRepository;
        private readonly IGenericRepository<ServiceDay> _serviceDayRepository;
        private readonly IDoctorServiceRepository _doctorServiceRepository;
        private readonly IDoctorRepository _doctorRepository;
        private readonly string _imagePath;
        public BookService( IBookingRepository bookingRepository, 
                            IUserRepository userRepository, 
                            IGenericRepository<ServiceDay> serviceDay,
                            IWebHostEnvironment webHostEnvironment, 
                            IDoctorServiceRepository doctorServiceRepository,
                            IDoctorRepository doctorRepository)
        {
            _bookingRepository = bookingRepository;
            _userRepository = userRepository;
            _serviceDayRepository = serviceDay;
            _imagePath = Path.Combine(webHostEnvironment.WebRootPath, FileSetting.ImagesPathBooking.TrimStart('/'));
            _doctorServiceRepository = doctorServiceRepository;
            _doctorRepository = doctorRepository;
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

        public async Task Book(BookServiceDto dto)
        {
            var user = await _userRepository.GetUserByIdAsync(dto.userId);
            if (user == null)
                throw new NotFoundException("UserNotFound");

            var serviceProvider = await _userRepository.GetUserByIdAsync(dto.serviceProviderId);
            if (serviceProvider == null)
                throw new NotFoundException("ServiceProviderNotFound");

            var serviceDay = await _serviceDayRepository.GetByIdAsync(dto.serviceDayId);
            if (serviceDay == null)
                throw new NotFoundException("ServiceDayNotFound");

            if (serviceDay.isBooking)
                throw new BadRequestException("ServiceAlreadyBooked");

            List<string> savedImages = new();
            if (dto.images != null)
            {
                foreach (var img in dto.images)
                {
                    var path = await FileOperation.SaveFile(img, _imagePath);
                    savedImages.Add(path);
                }
            }

            var booking = new Booking
            {
                userId = dto.userId,
                serviceProviderId = dto.serviceProviderId,
                price = dto.price,
                serviceProviderType = dto.serviceProviderType,
                bookingDate = dto.bookingDate,
                bookingType = dto.bookingType,
                day = dto.day,
                start = serviceDay.start,
                end = serviceDay.end,
                images = savedImages,
                serviceDayId = dto.serviceDayId   
            };

            serviceDay.isBooking = true;
            _serviceDayRepository.Update(serviceDay);

            if (serviceProvider is Doctor doc)
            {
                doc.NumberOfPatient += 1;
                _doctorRepository.Update(doc);
            }

            await _bookingRepository.AddAsync(booking);

            try
            {
                await _bookingRepository.SaveChangesAsync();   
            }
            catch (DbUpdateException ex)
            {
                throw new Exception(ex.InnerException?.Message ?? ex.Message);
            }
        }

    }
}
