namespace Wasla_Backend.DTOs
{
    public class AddRoleDto
    {
        public MultilingualText RoleName { get; set; }
        public string Value { get; set; }
        public IFormFile Image { get; set; } 
    }
}
