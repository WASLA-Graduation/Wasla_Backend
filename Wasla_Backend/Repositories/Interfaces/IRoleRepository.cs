namespace Wasla_Backend.Repositories.Interfaces
{
    public interface IRoleRepository
    {

        Task<bool> RoleExistsAsync(string roleName);
        Task<IdentityResult> CreateRoleAsync(ApplicationRole role);
        Task<IdentityResult> AddUserToRoleAsync(ApplicationUser user, string roleName);
        Task<IList<string>> GetUserRolesAsync(ApplicationUser user);
        Task<IList<ApplicationRole>> GetAllRolesAsync();
    }
}
