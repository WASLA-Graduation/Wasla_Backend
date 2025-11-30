namespace Wasla_Backend.Helpers.BackgroundServiceHelper
{
    public class BookingStatusUpdaterService : BackgroundService
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly ILogger<BookingStatusUpdaterService> _logger;
        private readonly TimeSpan _interval = TimeSpan.FromMinutes(1);

        public BookingStatusUpdaterService(
            IServiceScopeFactory scopeFactory,
            ILogger<BookingStatusUpdaterService> logger)
        {
            _scopeFactory = scopeFactory;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("BookingStatusUpdaterService started.");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    using var scope = _scopeFactory.CreateScope();
                    var db = scope.ServiceProvider.GetRequiredService<Context>();

                    var now = DateTime.Now;

                    var bookings = await db.Booking
                        .Include(b => b.serviceDay)
                        .Where(b =>
                            b.bookingStatus == BookingStatus.upcoming &&
                            DateTime.Parse($"{b.bookingDate} {b.serviceDay.dayOfWeek}") <= now
                        )
                        .ToListAsync(stoppingToken);

                    if (bookings.Any())
                    {
                        foreach (var booking in bookings)
                        {
                            booking.bookingStatus = BookingStatus.completed;

                            if (booking.serviceDay != null)
                                booking.serviceDay.isBooking = false;
                        }

                        await db.SaveChangesAsync(stoppingToken);
                        _logger.LogInformation("Updated {count} bookings at {time}.", bookings.Count, now);
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error during BookingStatusUpdaterService execution.");
                }

                await Task.Delay(_interval, stoppingToken);
            }

            _logger.LogInformation("BookingStatusUpdaterService stopped.");
        }
    }

}
