namespace Wasla_Backend.Mappings
{
    public class DoctorProfile : Profile
    {
        public DoctorProfile() 
        {
            CreateMap<DoctorCompleteDto, Doctor>();
        
        }
    }
}
