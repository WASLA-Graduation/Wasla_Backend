namespace Wasla_Backend.Services.Implementation
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly string _imagePath;

        public RoleService(IRoleRepository roleRepository, UserManager<ApplicationUser> userManager, IWebHostEnvironment webHostEnvironment)
        {
            _roleRepository = roleRepository;
            _userManager = userManager;
            _imagePath = Path.Combine(webHostEnvironment.WebRootPath, FileSetting.ImagesPathRole.TrimStart('/'));
        }

        public async Task<IdentityResult> AddRoleAsync(AddRoleDto roleDto)
        {
            if (await _roleRepository.RoleExistsAsync(roleDto.RoleName))
                throw new BadRequestException("Role already exists.");

            var image = await Images.SaveImage(roleDto.Image, _imagePath);

            var Role = new ApplicationRole();
            
            Role.Name = roleDto.RoleName;
            Role.ImageUrl = image;

            return await _roleRepository.CreateRoleAsync(Role);
        }

        public async Task<IList<string>> GetUserRolesAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId)
                       ?? throw new NotFoundException("User not found.");

            return await _roleRepository.GetUserRolesAsync(user);
        }

        public async Task<IList<ApplicationRole>> GetAllRolesAsync()
        {
            return await _roleRepository.GetAllRolesAsync();
        }
    }

}
