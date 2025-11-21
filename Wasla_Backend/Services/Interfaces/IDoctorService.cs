
namespace Wasla_Backend.Services.Interfaces
{
    public interface IDoctorService
    {
        public Task CompleteData(DoctorCompleteDto doctorCompleteDto);
        public Task<IEnumerable<DoctorSpecializationResponse>> DoctorSpecializations(string lan);
        public Task<IEnumerable<DoctorProfileResponse>> GetDoctorProfile(string id, string lan);
    }
}
