using System.Collections.Generic;

namespace Battle4Beers.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<Beer> BeersToBeTaken { get; set; } = new List<Beer>();

        public virtual List<Beer> BeersToBeGiven { get; set; } = new List<Beer>();
    }
}
