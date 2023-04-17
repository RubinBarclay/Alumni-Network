using Alumni_Network.Models;
using Alumni_Network.Models.DTOs.User;

namespace Alumni_Network.Services.User
{
    public class UserService : IUserService
    {
        private readonly AlumniDbContext _context;

        public UserService(AlumniDbContext context)
        {
            _context = context;
        }

        public Task<GetUserDTO> GetUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetUserByIdDTO> GetUserByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CreateUserDTO> CreateUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EditUserDTO> EditUserAsync()
        {
            throw new NotImplementedException();
        }

    }
}
