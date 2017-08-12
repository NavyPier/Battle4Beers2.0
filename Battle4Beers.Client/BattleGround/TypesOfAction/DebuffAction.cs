using Battle4Beers.Client.Models;

namespace Battle4Beers.Client.BattleGround.TypesOfAction
{
    public class DebuffAction
    {
        public static void ExecuteAction(Action action, Hero player, Hero target)
        {
            HeroCooldownReductor.ReduceCooldowns(player);
            Debuff buff = (Debuff)action;
            buff.GivePlayerDebuff(buff, player, target);
            ActionResult.ShowActionResult($"{target.Name} GOT DEBUFFED WITH {action.Name} BY {player.Name}");
        }
    }
}
