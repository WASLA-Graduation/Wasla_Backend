
using Microsoft.AspNetCore.Mvc.Razor;

namespace Wasla_Backend.Services.Implementation
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<DoctorService> _localizer;
        private readonly IGenericRepository<DoctorSpecialization> _doctorSpecializationRepository;
        private readonly string _imagePath;
        private readonly string _cvPath;

        public DoctorService(IDoctorRepository doctorRepository, 
            IWebHostEnvironment webHostEnvironment, 
            IMapper mapper, 
            IStringLocalizer<DoctorService> localizer,
            IGenericRepository<DoctorSpecialization> doctorSpecializationRepository)
        {
            _doctorRepository = doctorRepository;
            _mapper = mapper;
            _localizer = localizer;
            _doctorSpecializationRepository = doctorSpecializationRepository;
            _imagePath = Path.Combine(webHostEnvironment.WebRootPath, FileSetting.ImagesPathUser.TrimStart('/'));
            _cvPath = Path.Combine(webHostEnvironment.WebRootPath, FileSetting.PathCVDoctor.TrimStart('/'));
        }
        public async Task CompleteData(DoctorCompleteDto doctorCompleteDto)
        {
            var doctor = await _doctorRepository.GetByEmail(doctorCompleteDto.Email);
            
            if(doctor == null)
                throw new NotFoundException(_localizer["UserNotFound"]);

            _mapper.Map(doctorCompleteDto, doctor);

            var image = await FileOperation.SaveFile(doctorCompleteDto.Image, _imagePath);
            var cv = await FileOperation.SaveFile(doctorCompleteDto.CV, _cvPath);
            
            doctor.ProfilePhoto = image;
            doctor.CV = cv;

            _doctorRepository.Update(doctor);
            await _doctorRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<DoctorSpecializationResponse>> DoctorSpecializations(string lan)
        {
            var doctorSpecialization = await _doctorSpecializationRepository.GetAllAsync();

            
            var SpecializationResponse = doctorSpecialization.Select(ds => new DoctorSpecializationResponse
            {
                Id = ds.Id,
                Name = ds.Specialization.GetText(lan)
            });

            return SpecializationResponse;
        }
    }
}
