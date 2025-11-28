namespace Wasla_Backend.Mappings
{
    public class DoctorProfile : Profile
    {
        public DoctorProfile() 
        {
            CreateMap<DoctorCompleteDto, Doctor>()
                .ForMember(d => d.hospitalname, o => o.MapFrom(s => s.hospitalName));

            CreateMap<Doctor, DoctorProfileResponse>()
            .ForMember(dest => dest.fullName, opt => opt.MapFrom(src => src.FullName))
            .ForMember(dest => dest.email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.phone, opt => opt.MapFrom(src => src.Phone))
            .ForMember(dest => dest.image, opt => opt.MapFrom(src => src.ProfilePhoto))
            .ForMember(dest => dest.latitude, opt => opt.MapFrom(src => src.Latitude))
            .ForMember(dest => dest.longitude, opt => opt.MapFrom(src => src.Longitude))
            .ForMember(dest => dest.birthDay, opt => opt.MapFrom(src => src.BirthDay))
            .ForMember(dest => dest.cv, opt => opt.MapFrom(src => src.CV))
            .ForMember(dest => dest.universityName, opt => opt.MapFrom(src => src.UniversityName)) 
            .ForMember(dest => dest.description, opt => opt.MapFrom(src => src.Description))
            .ForMember(dest => dest.experienceYears, opt => opt.MapFrom(src => src.ExperienceYears))
            .ForMember(dest => dest.graduationYear, opt => opt.MapFrom(src => src.GraduationYear))
            .ForMember(d => d.hospitalName, o => o.MapFrom(s => s.hospitalname))
            .ForMember(dest => dest.specializationName,
                       opt => opt.MapFrom((src, dest, destMember, context) =>
                       src.Specialization.Specialization.GetText(context.Items["lan"].ToString())));

            CreateMap<Doctor, AllDoctorDataDto>()
                .ForMember(d => d.id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.fullName, o => o.MapFrom(s => s.FullName))
                .ForMember(d => d.experienceYears, o => o.MapFrom(s => s.ExperienceYears))
                .ForMember(d => d.rating, o => o.MapFrom(s => s.Rating))
                .ForMember(d => d.universityName, o => o.MapFrom(s => s.UniversityName))
                .ForMember(d => d.graduationYear, o => o.MapFrom(s => s.GraduationYear))
                .ForMember(d => d.hospitalName, o => o.MapFrom(s => s.hospitalname))
                .ForMember(d => d.numberOfPatient, o => o.MapFrom(s => s.NumberOfPatient))
                .ForMember(d => d.birthDay, o => o.MapFrom(s => s.BirthDay))
                .ForMember(d => d.phone, o => o.MapFrom(s => s.Phone))
                .ForMember(d => d.latitude, o => o.MapFrom(s => s.Latitude))
                .ForMember(d => d.longitude, o => o.MapFrom(s => s.Longitude))
                .ForMember(d => d.description, o => o.MapFrom(s => s.Description))
                .ForMember(d => d.imageName, o => o.MapFrom(s => s.ProfilePhoto))
                .ForMember(d => d.cv, o => o.MapFrom(s => s.CV));
        }
    }
}
