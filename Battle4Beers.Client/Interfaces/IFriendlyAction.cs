using Battle4Beers.Client.Models;

namespace Battle4Beers.Client.Interfaces
{
    public interface IFriendlyAction
    {
        void DoFriendlyAction(Hero player, Hero ally);
    }
}
