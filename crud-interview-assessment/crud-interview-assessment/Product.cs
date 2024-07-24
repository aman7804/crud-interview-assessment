using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace crud_interview_assessment
{
	public class Product
	{
		[Key]
		public int ProductNo { get; set; }

		[Required, StringLength(100)]
		public string ProductName { get; set; }

		[Required, Column(TypeName = "decimal(18,2)")]
		public decimal CostPrice { get; set; }

		[Required]
		public int Qty { get; set; }

		[Required, Column(TypeName = "decimal(18,2)")]
		public decimal SalesPrice { get; set; }
	}
}
