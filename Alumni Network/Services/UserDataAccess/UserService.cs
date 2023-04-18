using Alumni_Network.Exceptions;
using Alumni_Network.Models;
using Alumni_Network.Models.Domain;

namespace Alumni_Network.Services.UserDataAccess
{
    public class UserService : IUserService
    {
        private readonly AlumniDbContext _context;

        public UserService(AlumniDbContext context)
        {
            _context = context;
        }

        public Task<User> GetUserAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            if (_context.Users == null)
            {
                throw new UsersNotFound();
            }

            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                throw new UserNotFound(id);
            }

            return user;
        }

        public Task<User> CreateUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> EditUserAsync()
        {
            throw new NotImplementedException();
        }
    }
}
