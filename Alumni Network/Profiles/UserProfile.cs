using Alumni_Network.Models.Domain;
using Alumni_Network.Models.DTOs.User;
using AutoMapper;

namespace Alumni_Network.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, GetUserDTO>();
            CreateMap<CreateUserDTO, User>();
            CreateMap<EditUserDTO, User>();
        }
    }
}
