namespace Wasla_Backend.Factories.Interfaces
{
    public interface IUserFactory
    {
        ApplicationUser CreateUser(string role);
    }
}
