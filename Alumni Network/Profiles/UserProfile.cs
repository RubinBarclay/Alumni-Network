using Alumni_Network.Models.Domain;
using Alumni_Network.Models.DTOs.User;
using AutoMapper;

namespace Alumni_Network.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, GetUserByIdDTO>();
            CreateMap<CreateUserDTO, User>();
            CreateMap<EditUserDTO, User>();
                //.ForMember(
                //    dest => dest.Id,
                //    opt => opt.MapFrom(src => src.Id)
                //)
                //.ForMember(
                //    dest => dest.Sub,
                //    opt => opt.MapFrom(src => src.Sub)
                //);
        }
    }
}
