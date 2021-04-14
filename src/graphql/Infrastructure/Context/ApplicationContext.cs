using graphql.Infrastructure.Configuration;
using graphql.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace graphql.Infrastructure.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ManufacturerConfiguration());
            modelBuilder.ApplyConfiguration(new GameSystemsConfiguration());
            modelBuilder.ApplyConfiguration(new GamesConfiguration());
        }
    }
}