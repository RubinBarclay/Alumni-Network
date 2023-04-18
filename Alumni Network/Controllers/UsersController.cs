using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Alumni_Network.Models;
using Alumni_Network.Models.Domain;
using Alumni_Network.Models.DTOs.User;
using AutoMapper;
using Alumni_Network.Services.UserDataAccess;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Alumni_Network.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;
        private readonly IMapper _mapper;

        public UsersController(IUserService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //// GET: api/Users
        //[HttpGet]
        //public async Task<ActionResult<User>> GetUser() { }

        // GET: api/users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetUserByIdDTO>> GetUserById(int id)
        {
            var user = await _service.GetUserByIdAsync(id);
            var userDTO = _mapper.Map<GetUserByIdDTO>(user);
            return Ok(userDTO);
        }

        //// PUT: api/Users/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> EditUser(int id, User user)
        //{
        //    //if (id != user.Id)
        //    //{
        //    //    return BadRequest();
        //    //}

        //    //_context.Entry(user).State = EntityState.Modified;

        //    //try
        //    //{
        //    //    await _context.SaveChangesAsync();
        //    //}
        //    //catch (DbUpdateConcurrencyException)
        //    //{
        //    //    if (!UserExists(id))
        //    //    {
        //    //        return NotFound();
        //    //    }
        //    //    else
        //    //    {
        //    //        throw;
        //    //    }
        //    //}

        //    //return NoContent();
        //}

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<GetUserByIdDTO>> CreateUser(CreateUserDTO userDTO)
        {
            // Extract the user sub (keycloak id) from the token
            var sub = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (sub == null)
            {
                return BadRequest("No sub claim found in token");
            }

            // Assign the sub (keycloak id) to the user DTO
            userDTO.Sub = sub;

            var user = _mapper.Map<User>(userDTO);

            await _service.CreateUserAsync(user, sub);

            return CreatedAtAction("CreateUser", new { id = user.Id }, user);
        }

        //private bool UserExists(int id)
        //{
        //    return (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
