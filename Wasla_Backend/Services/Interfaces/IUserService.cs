using Wasla_Backend.DTOs.Authentication;

namespace Wasla_Backend.Services.Interfaces
{
    public interface IUserService
    {
        public Task<IdentityResult> RegisterAsync(RegisterDto model);
    }
}
