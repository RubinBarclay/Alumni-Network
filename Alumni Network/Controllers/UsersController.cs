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
using Alumni_Network.Exceptions.UserExceptions;

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

        // GET: api/users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetUserDTO>> GetUser(int id)
        {
            var user = await _service.GetUserAsync(id);
            var userDTO = _mapper.Map<GetUserDTO>(user);
            return Ok(userDTO);
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<GetUserDTO>> CreateUser(CreateUserDTO userDTO)
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

            try
            {
                await _service.CreateUserAsync(user, sub);
            }
            catch (UserAlreadyExists ex)
            {
                // User already has an account, return the user DTO along with a 200 status code
                var existingUserDTO = _mapper.Map<GetUserDTO>(ex.User);
                return Ok(existingUserDTO);
            }

            return CreatedAtAction("CreateUser", new { id = user.Id }, user);
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> EditUser(int id, EditUserDTO userDTO)
        {
            var user = _mapper.Map<User>(userDTO);

            await _service.EditUserAsync(id, user);

            return NoContent();
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await _service.DeleteUserAsync(id);
            return NoContent();
        }
    }
}
