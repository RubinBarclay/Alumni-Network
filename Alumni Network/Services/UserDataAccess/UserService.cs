using Alumni_Network.Exceptions;
using Alumni_Network.Models;
using Alumni_Network.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Alumni_Network.Services.UserDataAccess
{
    public class UserService : IUserService
    {
        private readonly AlumniDbContext _context;

        public UserService(AlumniDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserAsync(int id)
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

            var userExists = _context.Users.FirstOrDefault(u => u.Sub == sub);

            if (userExists != null)
            {
                throw new UserAlreadyExists(sub);
            }

            _context.Users.Add(user);

            await _context.SaveChangesAsync();
        }

        public async Task EditUserAsync(int id, User user)
        {
            var existingUser = await GetUserAsync(id);

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

        public async Task DeleteUserAsync(int id)
        {
            var user = await GetUserAsync(id);

            if (user == null)
            {
                throw new UserNotFound(id);
            }

            _context.Users.Remove(user);

            await _context.SaveChangesAsync();
        }
    }
}
