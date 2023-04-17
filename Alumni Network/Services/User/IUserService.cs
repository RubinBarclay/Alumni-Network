using Alumni_Network.Models.DTOs.User;

namespace Alumni_Network.Services.User
{
    public interface IUserService
    {
        public Task<GetUserDTO> GetUserAsync();
        public Task<GetUserByIdDTO> GetUserByIdAsync();
        public Task<CreateUserDTO> CreateUserAsync();
        public Task<EditUserDTO> EditUserAsync();
    }
}
