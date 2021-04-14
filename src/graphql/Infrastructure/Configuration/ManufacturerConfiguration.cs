using graphql.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace graphql.Infrastructure.Configuration
{
    public class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.ToTable("manufacturers");

            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.Name).HasColumnName("name");
            builder.Property(p => p.YearFounded).HasColumnName("yearfounded");

            builder.HasMany(p => p.Systems)
                .WithOne(p => p.Manufacturer)
                .HasForeignKey(p => p.ManufacturerId);
        }
    }
}