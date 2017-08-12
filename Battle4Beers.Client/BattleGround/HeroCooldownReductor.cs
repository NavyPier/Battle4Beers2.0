using Battle4Beers.Client.Models;

namespace Battle4Beers.Client.BattleGround
{
    public class HeroCooldownReductor
    {
        public static void ReduceCooldowns(Hero player)
        {
            foreach(var action in player.Actions)
            {
                action.ReduceCooldown();
            }
        }
    }
}
