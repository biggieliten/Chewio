using Microsoft.EntityFrameworkCore;

class ChewioDbContext : DbContext
{
	public ChewioDbContext(DbContextOptions options) : base(options) { }

}