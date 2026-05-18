namespace Wasla_Backend.Hubs.RestaurantHubs
{
    public class RestaurantHub : Hub
    {
        public async Task JoinRestaurantGroup(int restaurantId)
        {
            await Groups.AddToGroupAsync(
                Context.ConnectionId,
                $"restaurant_{restaurantId}"
            );
        }

        public async Task LeaveRestaurantGroup(int restaurantId)
        {
            await Groups.RemoveFromGroupAsync(
                Context.ConnectionId,
                $"restaurant_{restaurantId}"
            );
        }
    }
}
