namespace Wasla_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpPost("BookService")]
        public async Task<IActionResult> BookService([FromForm] BookServiceDto bookServiceDto, string lan = "en")
        {
                await _bookService.Book(bookServiceDto);
                return Ok(ResponseHelper.Success("ServiceBookedSuccessfully", lan));
        }

        [HttpGet("GetBookingDetailsForUser")]
        public async Task<IActionResult> GetBookingDetailsForUser([FromQuery]string userId, [FromQuery] string language="en")
        {
            var bookingDetails = await _bookService.GetBookingDetailsForUserAsync(userId, language);
            return Ok(ResponseHelper.Success("BookingRetrievedsuccess", language, bookingDetails));
        }
        [HttpPut("ConfermBooking/{serviceDayId}")]
        public async Task<IActionResult> ConfermBooking(int serviceDayId,string lan="en")
        {
            await _bookService.ConfermBooking(serviceDayId);
            return Ok(ResponseHelper.Success("BookingConfirmedSuccessfully", lan));
        }
    }
}
