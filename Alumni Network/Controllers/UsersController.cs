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

        // GET: api/Users/5
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

        //// POST: api/Users
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<User>> CreateUser(User user)
        //{
        //  //if (_context.Users == null)
        //  //{
        //  //    return Problem("Entity set 'AlumniDbContext.Users'  is null.");
        //  //}
        //  //  _context.Users.Add(user);
        //  //  await _context.SaveChangesAsync();

        //  //  return CreatedAtAction("GetUser", new { id = user.Id }, user);
        //}

        //private bool UserExists(int id)
        //{
        //    return (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
