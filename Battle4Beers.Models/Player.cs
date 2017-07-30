using System.Collections.Generic;

namespace Battle4Beers.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<SingleScore> SingleScores { get; set; } = new List<SingleScore>();
        public virtual List<TeamScore> TeamScores { get; set; } = new List<TeamScore>();
    }
}
