namespace graphql.Infrastructure.Models
{
    public class Game
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long GameSystemId { get; set; }
        public short YearReleased { get; set; }

        public virtual GameSystem GameSystem { get; set; }
    }
}