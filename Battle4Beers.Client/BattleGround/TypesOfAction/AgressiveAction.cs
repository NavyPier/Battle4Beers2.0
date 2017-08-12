using System;
using Battle4Beers.Client.Models;
using Battle4Beers.Client.Interfaces;

namespace Battle4Beers.Client.BattleGround
{
    public class AgressiveAction
    {
        public static void ExecuteAction(Models.Action action, Hero player, Hero target)
        {
            IAgressiveAction currentAction = (IAgressiveAction)action;
            currentAction.ExecuteAgressiveAction(player, target);
        }
    }
}
