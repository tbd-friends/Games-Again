using graphql.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace graphql.Infrastructure.Configuration
{
    public class GamesConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.ToTable("games");

            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.Name).HasColumnName("name");
            builder.Property(p => p.Description).HasColumnName("description");
            builder.Property(p => p.GameSystemId).HasColumnName("gamesystemid");
            builder.Property(p => p.YearReleased).HasColumnName("yearreleased");
        }
    }
}