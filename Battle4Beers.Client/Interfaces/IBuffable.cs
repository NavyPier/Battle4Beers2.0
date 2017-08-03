using Battle4Beers.Client.Models;
using System.Collections.Generic;

namespace Battle4Beers.Client.Interfaces
{
    public interface IBuffable
    {
        List<Buff> Buffs { get; }
        List<Debuff> Debuffs { get; }
    }
}
