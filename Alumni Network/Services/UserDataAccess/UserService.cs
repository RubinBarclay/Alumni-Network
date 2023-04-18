using Alumni_Network.Exceptions;
using Alumni_Network.Models;
using Alumni_Network.Models.Domain;
using Microsoft.EntityFrameworkCore;

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

        public async Task CreateUserAsync(User user, string sub)
        {
            if (_context.Users == null)
            {
                throw new UsersNotFound();
            }

            var userExists = await _context.Users.SingleOrDefaultAsync(u => u.Sub == sub);

            if (userExists != null)
            {
                throw new UserAlreadyExists(sub);
            }

            _context.Users.Add(user);

            await _context.SaveChangesAsync();
        }

        public Task<User> EditUserAsync()
        {
            throw new NotImplementedException();
        }
    }
}
