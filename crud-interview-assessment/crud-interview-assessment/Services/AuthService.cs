using crud_interview_assessment.DTOs;
using crud_interview_assessment.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace crud_interview_assessment.Services
{
	public class AuthService : IAuthService
	{
		private readonly ApplicationDbContext _context;

		public AuthService(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<User> Login(LoginDTO loginDTO)
		{
			User? user = await _context.Users.FirstOrDefaultAsync(e => e.EmailId == loginDTO.EmailId)
				?? throw new Exception("NOT FOUND");

			if (!Encrypt(loginDTO.Password).Equals(user.Password))
				throw new Exception("PASSWORD_INCORRECT");

			return user;
		}

		public async Task RegisterUser(RegisterDTO registerDTO)
		{
			User user = new User
			{
				Name = registerDTO.Name,
				EmailId = registerDTO.EmailId,
				Password = Encrypt(registerDTO.Password)
			};
			_context.Users.Add(user);
			await _context.SaveChangesAsync();
		}

		private static string Encrypt(string text)
		{
			string EncryptionKey = "A#$Derclfkdws"; // SecurityKey
			byte[] clearBytes = Encoding.Unicode.GetBytes(text);
			using (Aes encryptor = Aes.Create())
			{
				Rfc2898DeriveBytes pdb = new(EncryptionKey, new byte[] {
					0x49,0x76,0x61,0x6e,0x20,0x4d,0x65,0x64,0x76,0x65,0x64,0x65,0x76
				});
				encryptor.Key = pdb.GetBytes(32);
				encryptor.IV = pdb.GetBytes(16);
				using MemoryStream ms = new();
				using (CryptoStream cs = new(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
				{
					cs.Write(clearBytes, 0, clearBytes.Length);
					cs.Close();
				}
				text = Convert.ToBase64String(ms.ToArray());
			}
			return text;
		}

	}
}
