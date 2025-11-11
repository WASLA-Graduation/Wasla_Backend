using Wasla_Backend.DTOs.RoleDTOS;

namespace Wasla_Backend.Services.Implementation
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly string _imagePath;
        private readonly IStringLocalizer<RoleService> _localizer;

        public RoleService(
            IRoleRepository roleRepository,
            UserManager<ApplicationUser> userManager,
            IWebHostEnvironment webHostEnvironment,
            IStringLocalizer<RoleService> localizer
        )
        {
            _roleRepository = roleRepository;
            _userManager = userManager;
            _localizer = localizer;
            _imagePath = Path.Combine(webHostEnvironment.WebRootPath, FileSetting.ImagesPathRole.TrimStart('/'));
        }
        public async Task<IdentityResult> AddRoleAsync(AddRoleDto roleDto)
        {
            if (await _roleRepository.RoleExistsAsync(roleDto.Value))
                throw new BadRequestException(_localizer["RoleAlreadyExists"]);

            var image = await FileOperation.SaveFile(roleDto.Image, _imagePath);

            var role = new ApplicationRole
            {
                RoleName = roleDto.RoleName,
                Name = roleDto.Value,
                ImageUrl = image
            };

            return await _roleRepository.CreateRoleAsync(role);
        }

        public async Task<IList<string>> GetUserRolesAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId)
                       ?? throw new NotFoundException(_localizer["UserNotFound"]);

            return await _roleRepository.GetUserRolesAsync(user);
        }

        public async Task<IList<RolesResponse>> GetAllRolesAsync(string lan)
        {
            var roles =  await _roleRepository.GetAllRolesAsync();
            if (roles == null || !roles.Any())
                throw new NotFoundException(_localizer["NoRolesFound"]);

            var rolesResult = roles.Select(rs => new RolesResponse
            {
                Id = rs.Id,
                Value = rs.Name,
                ImageName = rs.ImageUrl,
                RoleName = rs.RoleName.GetText(lan)
            }).ToList();

            return rolesResult;
        }
    }
}
