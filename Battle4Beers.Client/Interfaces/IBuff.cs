using Battle4Beers.Client.Models;

namespace Battle4Beers.Client.Interfaces
{
    public interface IBuff
    {
        int Duration { get; }
        void BuffPlayer(Hero player);
        void GivePlayerBuff(Buff buff, Hero player);
        void ReduceDuration(Hero player);
    }
}
