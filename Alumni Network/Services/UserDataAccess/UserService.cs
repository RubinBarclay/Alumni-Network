using Alumni_Network.Exceptions;
using Alumni_Network.Exceptions.UserExceptions;
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

        //public async Task<User> GetUserBySubAsync(string sub)
        //{
        //    if (_context.Users == null)
        //    {
        //        throw new UsersNotFound();
        //    }

        //    var user = await _context.Users.FirstOrDefaultAsync(u => u.Sub == sub);

        //    if (user == null)
        //    {
        //        throw new UserNotFound(sub);
        //    }

        //    return user;
        //}

        public async Task CreateUserAsync(User user, string sub)
        {
            if (_context.Users == null)
            {
                throw new UsersNotFound();
            }

            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Sub == sub);

            if (existingUser != null)
            {
                throw new UserAlreadyExists(sub, existingUser);
            }

            _context.Users.Add(user);

            await _context.SaveChangesAsync();
        }

        public async Task EditUserAsync(int id, User user)
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

            _context.Entry(existingUser).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = await GetUserByIdAsync(id);

            if (user == null)
            {
                throw new UserNotFound(id);
            }

            _context.Users.Remove(user);

            await _context.SaveChangesAsync();
        }
    }
}
