using graphql.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace graphql.Infrastructure.Configuration
{
    public class GameSystemsConfiguration : IEntityTypeConfiguration<GameSystem>
    {
        public void Configure(EntityTypeBuilder<GameSystem> builder)
        {
            builder.ToTable("gamesystems");

            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.Name).HasColumnName("name");
            builder.Property(p => p.ManufacturerId).HasColumnName("manufacturerid");
            builder.Property(p => p.YearReleased).HasColumnName("yearreleased");
        }
    }
}