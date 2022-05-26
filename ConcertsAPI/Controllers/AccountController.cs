using AutoMapper;
using ConcertsAPI.Contracts;
using ConcertsAPI.Models.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConcertsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAuthManager _authManager;

        public AccountController(IAuthManager authManager)
        {
            _authManager = authManager;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            var loginResult = await _authManager.Login(loginDto);

            if (loginResult == null)
            {
                return Unauthorized();
            }

            return Ok(loginResult);


        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] ApiUserDto apiUserDto)
        {
            var errors = await _authManager.Register(apiUserDto);

            if(errors != null)
            {
                foreach(var error in errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);

                }
                return BadRequest(ModelState);
            }

            return Ok();

        }

        [HttpPost]
        [Route("refreshtoken")]
        public async Task<IActionResult> RefreshToken([FromBody] AuthResponseDto authResponseDto)
        {
            var authResponse = await _authManager.VerifyRefreshToken(authResponseDto);
            if(authResponse == null)
            {
                return Unauthorized();
            }

            return Ok(authResponse);

        }

    }
}
