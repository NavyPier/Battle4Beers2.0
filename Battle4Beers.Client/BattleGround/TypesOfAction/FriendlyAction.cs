using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Models;

namespace Battle4Beers.Client.BattleGround
{
    public class FriendlyAction
    {
        public static void ExecuteAction(Models.Action action, Hero player, Hero target)
        {
            IFriendlyAction currentAction = (IFriendlyAction)action;
            currentAction.DoFriendlyAction(player, target);
        }
    }
}
