using Microsoft.EntityFrameworkCore;

namespace crud_interview_assessment
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options) { }

		public DbSet<Product> Products { get; set; }
	}
}
