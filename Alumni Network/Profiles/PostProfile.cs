using Alumni_Network.Models.Domain;
using Alumni_Network.Models.DTOs.PostDTOs;
using AutoMapper;

namespace Alumni_Network.Profiles
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Post, GetPostDTO>()
                .ForMember(dest => dest.Replies,
                opt => opt.MapFrom(replies => replies.Replies.Select(x => x.Id)));
            //CreateMap<CreateUserDTO, User>();
            //CreateMap<EditUserDTO, User>();
        }
    }
}
