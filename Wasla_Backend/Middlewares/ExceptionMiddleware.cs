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

            var lan = context.Request.Query["lan"].ToString();
            if (string.IsNullOrWhiteSpace(lan))
                lan = context.Request.Headers["Accept-Language"].ToString().Split(',').FirstOrDefault() ?? "en";
            if (string.IsNullOrWhiteSpace(lan))
                lan = "en";

            string messageKey;
            HttpStatusCode statusCode;

            switch (ex)
            {
                case BadRequestException:
                case ArgumentException:
                    statusCode = HttpStatusCode.BadRequest;
                    messageKey = "InvalidRequest";
                    break;
                case NotFoundException:
                    statusCode = HttpStatusCode.NotFound;
                    messageKey = "UserNotFound";
                    break;
                case UnauthorizedException:
                    statusCode = HttpStatusCode.Unauthorized;
                    messageKey = "LoginFailed";
                    break;
                default:
                    statusCode = HttpStatusCode.InternalServerError;
                    messageKey = "ServerError";
                    break;
            }

            var response = ResponseHelper.Fail(messageKey, lan, ex.Message);

            context.Response.StatusCode = (int)statusCode;

            var json = JsonSerializer.Serialize(response, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            await context.Response.WriteAsync(json);
        }
    }
}
