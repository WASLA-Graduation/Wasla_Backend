namespace Wasla_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpPost("CompleteData")]
        public async Task<IActionResult> CompleteData([FromForm] DoctorCompleteDto doctorCompleteDto, string lan = "en")
        {
            try
            {
                await _doctorService.CompleteData(doctorCompleteDto);
                return Ok(ResponseHelper.Success("CompleteDataSuccess", lan));
            }
            catch (NotFoundException ex)
            {
                return NotFound(ResponseHelper.Fail(ex.Message, lan));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ResponseHelper.Fail("ServerError", lan, ex.Message));

            }
        }
        [HttpGet("DoctorSpecializations")]
        public async Task<IActionResult> DoctorSpecializations(string lan = "en")
        {
            try
            {
                var specializations = await _doctorService.DoctorSpecializations(lan);
                return Ok(ResponseHelper.Success("FetchDoctorSpecializationsSuccess", lan, specializations));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ResponseHelper.Fail("ServerError", lan, ex.Message));
            }
        }
    }
}
