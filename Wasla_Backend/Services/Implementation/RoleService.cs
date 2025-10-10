namespace Wasla_Backend.Services.Implementation
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public RoleService(IRoleRepository roleRepository, UserManager<ApplicationUser> userManager)
        {
            _roleRepository = roleRepository;
            _userManager = userManager;
        }

        public async Task<IdentityResult> AddRoleAsync(string roleName)
        {
            if (await _roleRepository.RoleExistsAsync(roleName))
                throw new Exception("Role already exists.");

            return await _roleRepository.CreateRoleAsync(roleName);
        }

        public async Task<IList<string>> GetUserRolesAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId)
                       ?? throw new Exception("User not found.");

            return await _roleRepository.GetUserRolesAsync(user);
        }

        public async Task<IList<IdentityRole>> GetAllRolesAsync()
        {
            return await _roleRepository.GetAllRolesAsync();
        }
    }

}
