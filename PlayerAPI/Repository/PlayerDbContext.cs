using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using PlayerAPI.Model;

namespace PlayerAPI.Repository
{
	public class PlayerDbContext : DbContext
	{
		public PlayerDbContext(DbContextOptions<PlayerDbContext> option) : base(option)
		{
		}
		public virtual DbSet<Player> Players { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
#if DEBUG
			optionsBuilder.EnableSensitiveDataLogging();
			optionsBuilder.LogTo(Console.WriteLine, new[] { RelationalEventId.CommandExecuted });

#endif
		}
		//protected override void OnModelCreating(ModelBuilder modelBuilder)
		//{
		//	if (modelBuilder is not null)
		//	{
		//		modelBuilder.ApplyConfigurationsFromAssembly(typeof(PlayerDbContext).Assembly);
		//	}

		//}
	}
}
