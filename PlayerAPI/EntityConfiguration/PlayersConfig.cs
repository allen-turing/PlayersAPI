using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayerAPI.Model;

namespace PlayerAPI.EntityConfiguration
{
	internal class PlayersConfig : IEntityTypeConfiguration<Player>
	{
		public void Configure(EntityTypeBuilder<Player> builder)
		{
			builder.ToTable("all_seasons");

			builder.HasKey(_ => new { _.Id })
			.HasName("PRIMARY");
		}
	}
}
