using Microsoft.AspNetCore.Mvc;
using SparkFur.Core.Interfaces;
using SparkFur.Models.Entitys;
using System.Reflection.Metadata.Ecma335;

namespace SparkFur.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{username}")]
        public async Task<IActionResult> Get(string username)
        {
            var user = await _userService.GetByUsernameAsync(username);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost("{username}")]
        public async Task<bool> Create(string username)
        {
            User addUser = new User()
            {
                Email = $"{username}@163.com",
                Id = Guid.NewGuid(),
                Username = username,

                UserType = Models.Enums.UserType.Premium,
                CreateTime = DateTime.Now
            };
         await _userService.AddAsync(addUser);
           
            return  true;
        }
    }
}
