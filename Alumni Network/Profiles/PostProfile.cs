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
                opt => opt.MapFrom(post => post.Replies.Select(x => x.Id).ToList())); // Send list of IDs or actual reply strings?
            CreateMap<CreatePostDTO, Post>();
            CreateMap<EditPostDTO, Post>();
        }
    }
}
