namespace Wasla_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> PreRegister(RegisterDto model, string lan = "en")
        {
            if (model.Password != model.ConfirmPassword)
                return BadRequest(ResponseHelper.Fail("PassMismatch", lan));

            var result = await _userService.RegisterAsync(model);

            if (!result.Succeeded)
                return BadRequest(ResponseHelper.Fail("RegistrationFailed", lan, result.Errors));
     
            var returnModel = new
            {
                model.Email,
                model.Role
            };

            return Ok(ResponseHelper.Success("RegistrationSuccess", lan, returnModel));
        }

    }
}
