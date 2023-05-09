using Alumni_Network.Exceptions.PostExceptions;
using Alumni_Network.Exceptions.UserExceptions;
using Alumni_Network.Models;
using Alumni_Network.Models.Domain;
using Alumni_Network.Services.UserDataAccess;
using Microsoft.EntityFrameworkCore;

namespace Alumni_Network.Services.PostDataAccess
{
    public class PostService : IPostService
    {
        private readonly AlumniDbContext _context;
        private readonly IUserService _userService;

        public PostService(AlumniDbContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        // For dedicated post pagae for THIS post
        // DONT KNOW HOW TO DO THIS WITHOUT USER ID, MAYBE US SUB OR AUTHORID?
        //public Task<Post> GetPostAsync()
        //{
        //    throw new NotImplementedException();
        //}

        // Same as GetPostAsync but with id
        public async Task<Post> GetPostByIdAsync(int id)
        {
            if (_context.Posts == null)
            {
                throw new PostsNotFound();
            }

            var post = await _context.Posts.Include(x => x.Replies).FirstOrDefaultAsync(x => x.Id == id); //.FindAsync(id);

            if (post == null)
            {
                throw new PostNotFound(id);
            }

            return post;
        }

        // For feed on home page for specific user
        public async Task<IEnumerable<Post>> GetPostsAsync(string sub)
        {
            var user = await _userService.GetUserBySubAsync(sub);

            if (_context.Posts == null)
            {
                throw new PostsNotFound();
            }

            return await _context.Posts
                .Where(p => p.TargetGroup.Members.Any(u => u.Id == user.Id))
                .ToListAsync();
        }

        // For user posts history feed on profile page
        public Task<IEnumerable<Post>> GetPostsByUserAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
