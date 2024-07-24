using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Hosting;

namespace crud_interview_assessment.Models
{
	public class Product: BaseEntity
	{
		[Required, StringLength(100)]
		public string ProductName { get; set; } = string.Empty!;

		[Required, Column(TypeName = "decimal(18,2)")]
		public decimal CostPrice { get; set; }

		[Required]
		public int Qty { get; set; }

		[JsonIgnore, Column(TypeName = "decimal(18,2)")]
		public decimal SalesPrice { get; set; }
/*
		private decimal CalculateSalesPrice()
		{
			decimal markup = 1.225m;  // 122.50% markup
			decimal vat = 0.1m;      // 10% VAT
			decimal basePrice = CostPrice * markup;
			return basePrice * vat;  
		}*/
	}
}
