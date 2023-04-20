using Alumni_Network.Models.Domain;

namespace Alumni_Network.Services.UserDataAccess
{
    public interface IUserService
    {
        public Task<User> GetUserAsync(int id);
        public Task CreateUserAsync(User user, string sub);
        public Task EditUserAsync(int id, User user);
        public Task DeleteUserAsync(int id);
    }
}
