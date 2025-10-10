namespace Wasla_Backend.Services.Interfaces
{
    public interface IRoleService
    {
        Task<IdentityResult> AddRoleAsync(AddRoleDto role);
        Task<IList<string>> GetUserRolesAsync(string userId);
        Task<IList<ApplicationRole>> GetAllRolesAsync();
    }
}
