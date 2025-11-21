namespace Wasla_Backend.Repositories.Interfaces
{
    public interface IDoctorRepository : IGenericRepository<Doctor>
    {
        public Task<Doctor> GetByEmail(string email);
        public Task<Doctor> GetById(string id);
    }
}
