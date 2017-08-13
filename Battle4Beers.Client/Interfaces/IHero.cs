using Battle4Beers.Client.Models;
using System.Collections.Generic;

namespace Battle4Beers.Client.Interfaces
{
    public interface IHero
    {
        string Name { get; }
        int Health { get; }
        int HealthRegen { get; }
        List<Action> Actions { get; }
    }
}
