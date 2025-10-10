namespace Wasla_Backend.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public Task<IdentityResult> CreateUserAsync(ApplicationUser user, string password);
    }
}
