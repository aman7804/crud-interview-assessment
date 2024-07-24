using System.ComponentModel.DataAnnotations;

namespace crud_interview_assessment.Models
{
	public class BaseEntity
	{
		[Key]
		public int Id { get; set; }
	}
}
