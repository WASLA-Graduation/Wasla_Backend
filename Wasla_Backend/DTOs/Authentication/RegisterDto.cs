namespace Wasla_Backend.DTOs.Authentication
{
    public class RegisterDto
    {
        [EmailAddress]
        public string Email { get; set; } = default!;

        [DataType(DataType.Password)]
        public string Password { get; set; } = default!;

        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = default!;

        public string Role { get; set; } = default!;
    }

}
