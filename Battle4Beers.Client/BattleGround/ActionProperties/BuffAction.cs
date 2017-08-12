using Battle4Beers.Client.Models;

namespace Battle4Beers.Client.BattleGround.TypesOfAction
{
    public class BuffAction
    {
        public static void ExecuteAction(Action action, Hero player, Hero target)
        {
            HeroCooldownReductor.ReduceCooldowns(player);
            Buff buff = (Buff)action;
            buff.GivePlayerBuff(buff, target);
            if (target.Name != player.Name)
            {
                ActionResult.ShowActionResult($"{player.Name} BUFFED {target.Name} WITH {action.Name}");
            }
            else
            {
                ActionResult.ShowActionResult($"{player.Name} BUFFED HIMSELF WITH {action.Name}");
            }
        }
    }
}
