using System.Collections;
using System.Collections.Generic;

namespace graphql.Infrastructure.Models
{
    public class Manufacturer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public short YearFounded { get; set; }

        public virtual ICollection<GameSystem> Systems { get; set; }
    }
}