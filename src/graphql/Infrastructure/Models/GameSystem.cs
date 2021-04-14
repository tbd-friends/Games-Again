namespace graphql.Infrastructure.Models
{
    public class GameSystem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long ManufacturerId { get; set; }
        public short YearReleased { get; set; }
        public long UnitsSold { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
    }
}