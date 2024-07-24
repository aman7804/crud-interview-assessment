using crud_interview_assessment.DTOs;
using crud_interview_assessment.Models;
using crud_interview_assessment.Services;
using EMS.Api.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IJwtUtils _jwtUtils;

        public AuthController(IAuthService authService, IJwtUtils jwtUtils)
        {
            _authService = authService;
            _jwtUtils = jwtUtils;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO dto)
        {
            User user = await _authService.Login(dto);
            return Ok(new { user, token = _jwtUtils.GenerateJwtToken(user.Id) });
        }

        [HttpPost("signup")]
        public async Task<IActionResult> RegisterUser(RegisterDTO dto)
        {
            await _authService.RegisterUser(dto);
            return NoContent();
        }

    }
}
