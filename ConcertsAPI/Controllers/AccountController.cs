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
        private readonly IMapper _mapper;
        private readonly IAuthManager _authManager;

        public AccountController(IMapper mapper, IAuthManager authManager)
        {
            _mapper = mapper;
            _authManager = authManager;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody]LoginDto loginDto)
        {
            var loginResult = await _authManager.Login(loginDto);

            if(loginResult == null)
            {
                return Unauthorized();
            }

            return Ok(loginResult);
            

        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(ApiUserDto apiUserDto)
        {


        }

        [HttpPost]
        [Route("refreshtoken")]
        public async Task<IActionResult> Login()
        {

        }

    }
}
