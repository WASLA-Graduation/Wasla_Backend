namespace Wasla_Backend.Factories.Implementation
{
    public class UserFactory : IUserFactory
    {
        public ApplicationUser CreateUser(string role)
        {
            return role.ToLower() switch
            {
                "doctor" => new Doctor(),
                "driver" => new Driver(),
                "resident" => new Resident(),
                "restaurant" => new Restaurant(),
                "gym" => new Gym(),
                "technician" => new Technician(),
                _ => throw new ArgumentException($"Unsupported role: {role}")
            };
        }
    }
}
