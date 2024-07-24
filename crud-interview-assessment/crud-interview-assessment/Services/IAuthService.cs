using crud_interview_assessment.DTOs;
using crud_interview_assessment.Models;

namespace crud_interview_assessment.Services
{
	public interface IAuthService
	{
		Task<User> Login(LoginDTO loginDTO);
		Task RegisterUser(RegisterDTO registerDTO);
	}
}
