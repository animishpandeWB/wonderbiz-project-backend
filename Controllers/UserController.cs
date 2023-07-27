using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial_Project.Models;
using Tutorial_Project.Services;
using Microsoft.AspNetCore.Mvc;

namespace Tutorial_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        public UserController()
        {

        }

        [HttpGet]
        public ActionResult<List<User>> GetAllUsers()
        {
            return UserService.GetAllUsers();
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = UserService.GetUser(id);
            if (user is null)
            {
                return NotFound();
            }
            return user;
        }

        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            UserService.AddUser(user);
            return CreatedAtAction(nameof(GetAllUsers), new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }
            var existingUser = UserService.GetUser(id);
            if (existingUser is null)
            {
                return NotFound();
            }
            UserService.UpdateUser(user);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = UserService.GetUser(id);

            if (user is null)
            {
                return NotFound();
            }

            UserService.DeleteUser(id);
            return NoContent();
        }
    }
}