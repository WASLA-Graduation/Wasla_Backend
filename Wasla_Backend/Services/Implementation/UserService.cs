using AutoMapper;
using Shoes_Ecommerce.Helpers.EmailSender;
using Wasla_Backend.DTOs;

namespace Wasla_Backend.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserFactory _userFactory;
        private readonly IUserRepository _userRepository;
        private readonly IEmailVerificationRepository _emailVerificationRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly EmailSenderHelper _emailSender;
        private readonly IMapper _mapper;

        public UserService(IUserFactory userFactory, IUserRepository userRepository, IEmailVerificationRepository emailVerificationRepository,IRoleRepository roleRepository,  EmailSenderHelper emailSender, IMapper mapper)
        {
            _userFactory = userFactory;
            _userRepository = userRepository;
            _emailVerificationRepository = emailVerificationRepository;
            _roleRepository = roleRepository;
            _emailSender = emailSender;
            _mapper = mapper;
        }

        public async Task<IdentityResult> RegisterAsync(RegisterDto model)
        {
            var user = _userFactory.CreateUser(model.Role);

            _mapper.Map(model, user);
            
            var result = await _userRepository.CreateUserAsync(user, model.Password);

            if (!result.Succeeded)
                return result;
            
            string verificationCode = new Random().Next(1000, 9999).ToString();

            await _emailSender.SendEmailAsync(
                        model.Email,
                        "Verification Code",
                        $"Your OTP is: <b>{verificationCode}</b>"
                    );

            await _emailVerificationRepository.AddVerificationAsync(model.Email,verificationCode,TimeSpan.FromMinutes(1));
       
            await _roleRepository.AddUserToRoleAsync(user, model.Role);

            return result;
        }


    }
}
