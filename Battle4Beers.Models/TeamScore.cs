using System.Collections.Generic;

namespace Battle4Beers.Models
{
    public class TeamScore
    {
        public int Id { get; set; }
        public long Score { get; set; }
        public virtual List<Player> Players { get; set; } = new List<Player>();

    }
}