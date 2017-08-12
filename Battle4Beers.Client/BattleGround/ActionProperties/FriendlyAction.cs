using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Models;

namespace Battle4Beers.Client.BattleGround
{
    public class FriendlyAction
    {
        public static void ExecuteAction(Models.Action action, Hero player, Hero target)
        {
            HeroCooldownReductor.ReduceCooldowns(player);
            IFriendlyAction currentAction = (IFriendlyAction)action;
            currentAction.DoFriendlyAction(player, target);
            if (player.Name != target.Name)
            {
                ActionResult.ShowActionResult($"{player.Name} USED {action.Name} ON HIS ALLY {target.Name}!");
            }
            else
            {
                ActionResult.ShowActionResult($"{player.Name} USED {action.Name} ON HIMSELF!");
            }
        }
    }
}
