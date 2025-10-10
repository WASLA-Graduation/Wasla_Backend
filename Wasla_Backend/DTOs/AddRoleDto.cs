namespace Wasla_Backend.DTOs
{
    public class AddRoleDto
    {
        public string RoleName { get; set; } = default!;
        public IFormFile Image { get; set; } = default!;
    }
}
