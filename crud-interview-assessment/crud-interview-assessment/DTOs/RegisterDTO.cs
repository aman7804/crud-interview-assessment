namespace crud_interview_assessment.DTOs
{
	public class RegisterDTO
	{
		public string Name { get; set; } = string.Empty;
		public string EmailId { get; set; } = string.Empty!;
		public string Password { get; set; } = string.Empty!;
	}
}
