using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace crud_interview_assessment.Models
{
	public class User: BaseEntity
	{
		[Required, StringLength(50)]
		public string Name { get; set; } = string.Empty!;

		[Required, StringLength(256)]
		public string EmailId { get; set; } = string.Empty!;

		[Required, StringLength(256), JsonIgnore]
		public string Password { get; set; } = string.Empty!;
	}
}
