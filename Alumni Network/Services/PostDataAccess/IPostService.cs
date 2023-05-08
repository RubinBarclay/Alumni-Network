using Alumni_Network.Models.DTOs.PostDTOs;

namespace Alumni_Network.Services.PostDataAccess
{
    public interface IPostService
    {
        public Task<GetPostDTO> GetPostByIdAsync();
        public Task<IEnumerable<GetPostDTO>> GetPostsAsync();
        public Task<IEnumerable<GetPostDTO>> GetPostsByUserAsync();
        //public Task<GetPostDTO> GetPostByIdAsync(int id);
    }
}
