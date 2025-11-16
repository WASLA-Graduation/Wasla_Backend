namespace Wasla_Backend.Repositories.Interfaces
{
    public interface IRestaurantRepository: IGenericRepository<Restaurant>
    {
        Task<Restaurant> GetByEmail(string email);
        Task<Restaurant>GetByName(string name);
        bool IsEmailExists(string email);
        bool IsNameExists(string name);
        Task<Restaurant>GetByOwnerName(string ownerName);
        bool IsOwnerExist(string ownerName);
    }
}
