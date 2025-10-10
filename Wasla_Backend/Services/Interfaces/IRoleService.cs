namespace Wasla_Backend.Services.Interfaces
{
    public interface IRoleService
    {
        Task<IdentityResult> AddRoleAsync(string roleName);
        Task<IList<string>> GetUserRolesAsync(string userId);
        Task<IList<IdentityRole>> GetAllRolesAsync();
    }
}
