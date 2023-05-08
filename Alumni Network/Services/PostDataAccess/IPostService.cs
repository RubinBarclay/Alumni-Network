using Alumni_Network.Models.Domain;

namespace Alumni_Network.Services.PostDataAccess
{
    public interface IPostService
    {
        //public Task<Post> GetPostAsync();
        public Task<IEnumerable<Post>> GetPostsAsync(string sub);
        public Task<Post> GetPostByIdAsync(int id);
        public Task<IEnumerable<Post>> GetPostsByUserAsync(int id);
    }
}
