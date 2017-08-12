using Battle4Beers.Client.Models;

namespace Battle4Beers.Client.Interfaces
{
    public interface IDebuff
    {
        int Duration { get; }
        void DebuffPlayer(Hero player);
        void GivePlayerDebuff(Debuff debuff, Hero player, Hero enemy);
        void ReduceDuration(Hero player);
    }
}
