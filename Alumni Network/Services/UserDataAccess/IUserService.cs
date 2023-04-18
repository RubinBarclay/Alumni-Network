using Alumni_Network.Models.Domain;

namespace Alumni_Network.Services.UserDataAccess
{
    public interface IUserService
    {
        public Task<User> GetUserAsync();
        public Task<User> GetUserByIdAsync(int id);
        public Task CreateUserAsync(User user, string sub);
        public Task<User> EditUserAsync();
    }
}
