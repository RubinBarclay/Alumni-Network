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

        public async Task<User> EditUserAsync(int id, User user)
        {
            var existingUser = await GetUserByIdAsync(id);

            if (existingUser == null)
            {
                throw new UserNotFound(id);
            }

            if (user.Name != null)
            {
                existingUser.Name = user.Name;
            }

            if (user.PictureUrl != null)
            {
                existingUser.PictureUrl = user.PictureUrl;
            }

            if (user.Status != null)
            {
                existingUser.Status = user.Status;
            }

            if (user.Bio != null)
            {
                existingUser.Bio = user.Bio;
            }

            if (user.FunFact != null)
            {
                existingUser.FunFact = user.FunFact;
            }

            await _context.SaveChangesAsync();
        }

        //public async Task EditUserAsync(int id, User user)
        //{

        //    _context.Entry(user).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        var userExists = (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();

        //        if (!userExists)
        //        {
        //            throw new UserNotFound(id);
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //}
    }
}
