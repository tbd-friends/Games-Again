using System.Linq;
using graphql.Infrastructure.Context;
using graphql.Infrastructure.Models;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;

namespace graphql.Infrastructure.Data
{
    public class Query
    {
        [UseDbContext(typeof(ApplicationContext))]
        [UsePaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Manufacturer> Manufacturers([ScopedService] ApplicationContext context) =>
            context.Manufacturers;

        [UseDbContext(typeof(ApplicationContext))]
        [UsePaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Game> Games([ScopedService] ApplicationContext context) =>
            context.Games;

        [UseDbContext(typeof(ApplicationContext))]
        public Game GetGameById(long id, [ScopedService] ApplicationContext context) =>
            (from g in context.Games
             where g.Id == id
             select g).SingleOrDefault();
    }
}