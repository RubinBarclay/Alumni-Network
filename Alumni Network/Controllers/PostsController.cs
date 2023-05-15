using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Alumni_Network.Models.DTOs.PostDTOs;
using Alumni_Network.Services.PostDataAccess;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Alumni_Network.Models.Domain;

namespace Alumni_Network.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _service;
        private readonly IMapper _mapper;

        public PostsController(IPostService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/Posts
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<GetPostDTO>>> GetPosts()
        {   
            var sub = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (sub == null)
            {
                return BadRequest("No sub claim found in token");
            }

            var posts = await _service.GetPostsAsync(sub);

            var postDTOs = _mapper.Map<IEnumerable<GetPostDTO>>(posts);

            return Ok(postDTOs);
        }

        // GET: api/Posts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetPostDTO>> GetPost(int id)
        {
            var post = await _service.GetPostByIdAsync(id);

            var postDTO = _mapper.Map<GetPostDTO>(post);

            return postDTO;
        }

        // POST: api/Posts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<GetPostDTO>> CreatePost(CreatePostDTO postDTO)
        {
            var sub = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (sub == null)
            {
                return BadRequest("No sub claim found in token");
            }

            var post = _mapper.Map<Post>(postDTO);

            var createdPost = await _service.CreatePostAsync(post, sub);

            var createdPostDTO = _mapper.Map<GetPostDTO>(createdPost);

            return CreatedAtAction("CreatePost", new { id = createdPostDTO.Id }, createdPostDTO);
        }

        // PUT: api/Posts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> EditPost(int id, EditPostDTO postDTO)
        {
            var post = _mapper.Map<Post>(postDTO);

            await _service.EditPostAsync(id, post);

            return NoContent();
        }

        // DELETE: api/Posts/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await _service.DeletePostAsync(id);

            return NoContent();
        }
    }
}
