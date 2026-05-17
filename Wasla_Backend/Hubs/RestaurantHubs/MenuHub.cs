namespace Wasla_Backend.Hubs.RestaurantHubs
{
    public class MenuHub : Hub
    {
        public async Task JoinRestaurantGroup(string restaurantId)
        {
            await Groups.AddToGroupAsync(
                Context.ConnectionId,
                $"restaurant_{restaurantId}"
            );
        }
    }
}
