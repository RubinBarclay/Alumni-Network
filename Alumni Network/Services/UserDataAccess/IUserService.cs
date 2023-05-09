using Alumni_Network.Models.Domain;

namespace Alumni_Network.Services.UserDataAccess
{
    public interface IUserService
    {
        public Task<User> GetUserByIdAsync(int id);
        //public Task<User> GetUserBySubAsync(string sub);
        public Task CreateUserAsync(User user, string sub);
        public Task EditUserAsync(int id, User user);
        public Task DeleteUserAsync(int id);
    }
}
