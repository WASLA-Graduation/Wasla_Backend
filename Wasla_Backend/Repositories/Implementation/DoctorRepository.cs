using Microsoft.AspNetCore.Identity;

namespace Wasla_Backend.Repositories.Implementation
{
    public class DoctorRepository : GenericRepository<Doctor> , IDoctorRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public DoctorRepository(UserManager<ApplicationUser> userManager, Context context) : base(context)
        {
            _userManager = userManager;
        }

        public async Task<Doctor> GetByEmail(string email)
        {
            return await _userManager.Users
                .OfType<Doctor>()
                .FirstOrDefaultAsync(d => d.Email == email);
        }

    }
}
