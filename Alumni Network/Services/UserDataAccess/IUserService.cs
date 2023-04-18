using Alumni_Network.Models.Domain;

namespace Alumni_Network.Services.UserDataAccess
{
    public interface IUserService
    {
        public Task<User> GetUserAsync();
        public Task<User> GetUserByIdAsync(int id);
        public Task<User> CreateUserAsync();
        public Task<User> EditUserAsync();
    }
}
