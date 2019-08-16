using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Facebook.WebApi.Models;
using Facebook.WebApi.View;
using Microsoft.AspNetCore.Mvc;

namespace Facebook.WebApi.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static IList<User> s_users = new List<User>
        {
            new User
            {
                Birthday = new DateTime(1992, 04,10),
                Email ="kikaslika@gmail.com",
                FirstName = "Kristija",
                Gender = Gender.Female,
                LastName = "Milka",
                Password = "123456",
                Username = "ulala_la_la"
            },
             new User
            {
                Birthday = new DateTime(1993, 10,2),
                Email ="kokismoki@gmail.com",
                FirstName = "Kole",
                Gender = Gender.Male,
                LastName = "kolovski",
                Password = "76543",
                Username = "skomi_stobiflips"
            },
             new User
            {
                Birthday = new DateTime(1994, 12,4),
                Email ="anjamanja@gmail.com",
                FirstName = "Ana",
                Gender = Gender.Female,
                LastName = "Manja",
                Password = "45666",
                Username = "anjanana"
            }
        };

        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return s_users;
        }

        [HttpGet("{username}")]
        public ActionResult<User> GetByUserName(string username)
        {
            var user = s_users.SingleOrDefault(u => u.Username == username);

            if(user == null )
            {
                return NotFound("the user does not exist!");
            }
            return user;
        }

        [HttpPost("create-user")]
        public IActionResult CreateNewUser(User user)
        {
            if (s_users.Any(u => u.Username == user.Username))
            {
                return Conflict("The user already exists!");
            }

            s_users.Add(user);
            string baseUrl = @"http://localhost:65378";
            return Created($"{baseUrl}/api/users/{user.Username}", user);
        }
        [HttpPut("{username}")]
        public IActionResult UpdateUser(UpdateUserViewModel viewModel, string username)
        {
            var user = s_users.SingleOrDefault(u => u.Username == username);
            if (user == null)

            {
                return NotFound($"User with username: {username} does not exist!");
            }

            user.Birthday = viewModel.Birthday;
            user.Email = viewModel.Email;
            user.FirstName = viewModel.FirstName;
            user.Gender = viewModel.Gender;
            user.LastName = viewModel.LastName;
            user.Password = viewModel.Password;

            return Ok(user);
            }
            [HttpDelete("{username}")]
            public IActionResult DeleteUser(string username)
            {
            var user = s_users.SingleOrDefault(u => u.Username == username);
            if (user == null)
                return StatusCode((int)HttpStatusCode.NotFound,
                    $"Username {username} does not exist");
                s_users.Remove(user);
                return NoContent();
            }
    }
}