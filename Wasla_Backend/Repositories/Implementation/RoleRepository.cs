namespace Wasla_Backend.Repositories.Implementation
{
    public class RoleRepository : IRoleRepository
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public RoleRepository(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<bool> RoleExistsAsync(string roleName)
            => await _roleManager.RoleExistsAsync(roleName);

        public async Task<IdentityResult> CreateRoleAsync(string roleName)
            => await _roleManager.CreateAsync(new IdentityRole(roleName));

        public async Task<IdentityResult> AddUserToRoleAsync(ApplicationUser user, string roleName)
                    => await _userManager.AddToRoleAsync(user, roleName);
        public async Task<IList<string>> GetUserRolesAsync(ApplicationUser user)
            => await _userManager.GetRolesAsync(user);

        public async Task<IList<IdentityRole>> GetAllRolesAsync()
            => await _roleManager.Roles.ToListAsync();

    }

}
