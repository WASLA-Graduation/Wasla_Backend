namespace Wasla_Backend.Repositories.Interfaces
{
    public interface IRoleRepository
    {

        Task<bool> RoleExistsAsync(string roleName);
        Task<IdentityResult> CreateRoleAsync(string roleName);
        Task<IdentityResult> AddUserToRoleAsync(ApplicationUser user, string roleName);
        Task<IList<string>> GetUserRolesAsync(ApplicationUser user);
        Task<IList<IdentityRole>> GetAllRolesAsync();
    }
}
