using System.Collections.Generic;
using Battle4Beers.Client.Models;

namespace Battle4Beers.Client.Interfaces
{
    public interface IBeersWriter
    {
        void Save(IEnumerable<Hero> winningTeam, IEnumerable<Hero> losingTeam);
    }
}