namespace Wasla_Backend.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unhandled exception");
                await HandleExceptionAsync(context, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";

            var statusCode = ex switch
            {
                BadRequestException => HttpStatusCode.BadRequest,         // 400
                NotFoundException => HttpStatusCode.NotFound,             // 404
                UnauthorizedException => HttpStatusCode.Unauthorized,     // 401
                ArgumentException => HttpStatusCode.BadRequest,           // 400
                _ => HttpStatusCode.InternalServerError                   // 500
            };

            var response = new
            {
                success = false,
                status = (int)statusCode,
                message = ex.Message
            };

            context.Response.StatusCode = (int)statusCode;
            await context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
    }
}
