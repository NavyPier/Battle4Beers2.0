using Battle4Beers.Client.Models;
using System.Collections.Generic;

namespace Battle4Beers.Client.BattleGround
{
    public class ActionGetter
    {
        public static void GetTypeOfAction(Action action, Hero player, List<Hero> firstTeam, List<Hero> secondTeam)
        {
            if (action.Type == "friendly")
            {
                var allyTeam = TargetTeamGetter.GetAllies(player, firstTeam, secondTeam);
                Hero target = ChooseTarget(allyTeam);
                FriendlyAction.ExecuteAction(action, player, target);
            }
            else if (action.Type == "agressive")
            {
                var enemyTeam = TargetTeamGetter.GetEnemies(player, firstTeam, secondTeam);
                Hero target = ChooseTarget(enemyTeam);
                AgressiveAction.ExecuteAction(action, player, target);
            }
            else
            {
                PassiveAction.ExecuteAction(action, player);
            }
        }

        private static Hero ChooseTarget(List<Hero> currentTeam)
        {
            return TypesOfMenu.SelectATarget(currentTeam);
        }
    }
}
