namespace Wasla_Backend.Controllers.Restaurant
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        [AllowAnonymous]
        [HttpPost("CompleteProfile")]
        public async Task<IActionResult> CompleteProfile([FromForm] CompleteRegisterRestaurantDto dto)
        {
            await _restaurantService.CompleteProfile(dto);

            return Ok(ResponseHelper.Success(LocalizationKey.ProfileCompletedSuccessfully,
                                             dto.lan));
        }

        [Authorize(Roles = "restaurant")]
        [HttpPut("UpdateRestaurant")]
        public async Task<IActionResult> UpdateRestaurant([FromForm] UpdateRestaurantDto dto)
        {
            await _restaurantService.UpdateRestaurant(dto);

            return Ok(ResponseHelper.Success(LocalizationKey.RestaurantUpdatedSuccessfully,
                                             dto.lan));
        }

        [Authorize(Roles = "restaurant")]
        [HttpPut("ChangeStatus")]
        public async Task<IActionResult> UpdateStatus([FromQuery] LanDto lanDto)
        {
            var userID = User.GetUserId();
            await _restaurantService.ChangeStatus(userID);
            return Ok(ResponseHelper.Success(LocalizationKey.RestaurantStatusChangeSuccessfully, lanDto.lan));
        }

        [Authorize(Roles = "restaurant,resident")]
        [HttpGet("Status")]
        public async Task<IActionResult> GetStatus(string userId ,[FromQuery] LanDto lanDto)
        {
            var status = await _restaurantService.GetStatus(userId);
            return Ok(ResponseHelper.Success(LocalizationKey.RestaurantStatusRetrievedSuccessfully, lanDto.lan, status));
        }

        [HttpGet("Restaurants")]
        public async Task<IActionResult> GetRestaurants([FromQuery] GetGeneralWithPaginationDto<int> dto)
        {
            var restaurants = await _restaurantService.GetAll(dto);

            return Ok(ResponseHelper.Success(LocalizationKey.RestaurantsRetrievedSuccessfully,
                                             dto.lan,
                                             restaurants));
        }

        [HttpGet]
        public async Task<IActionResult> GetRestaurant([FromQuery] GetGeneralDto<string> dto)
        {
            var restaurant = await _restaurantService.GetRestaurant(dto);

            return Ok(ResponseHelper.Success(LocalizationKey.RestaurantRetrievedSuccessfully,
                                             dto.lan,
                                             restaurant));
        }

        [Authorize(Roles = "restaurant")]
        [HttpGet("Charts")]
        public async Task<IActionResult> GetCharts([FromQuery] GetGeneralDto<string> dto)
        {
            var charts = await _restaurantService.GetCharts(dto.id);

            return Ok(ResponseHelper.Success(LocalizationKey.RestaurantChartsRetrievedSuccessfully,
                                             dto.lan,
                                             charts));
        }
    
    }
}