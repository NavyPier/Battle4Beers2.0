using Battle4Beers.Client.Models;

namespace Battle4Beers.Client.Interfaces
{
    public interface IAgressiveAction
    {
        int Damage { get; }
        void ExecuteAgressiveAction(Hero player, Hero enemy);
    }
}
