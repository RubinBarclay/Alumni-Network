using Alumni_Network.Models;
using Alumni_Network.Models.DTOs.PostDTOs;
using Alumni_Network.Services.UserDataAccess;

namespace Alumni_Network.Services.PostDataAccess
{
    public class PostService : IPostService
    {
        private readonly AlumniDbContext _context;

        public PostService(AlumniDbContext context)
        {
            _context = context;
        }

        //public async Task<GetPostDTO> GetPostByIdAsync()
        //{
        //    if (_context.Posts == null)
        //    {
        //        throw new PostsNotFound();
        //    }
        //    var post = await _context.Posts.FindAsync(id);
        //    if (post == null)
        //    {
        //        throw new PostNotFound(id);
        //    }
        //    return post;
        //}

        public async Task<IEnumerable<GetPostDTO>> GetPostsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GetPostDTO>> GetPostsByUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetPostDTO> GetPostByIdAsync()
        {
            if (_context.Posts == null)
            {
                throw new PostsNotFound();
            }
            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                throw new PostNotFound(id);
            }
            return post;
            //throw new NotImplementedException();
        }
    }
}
