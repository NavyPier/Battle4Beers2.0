using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Models;

namespace Battle4Beers.Client.BattleGround.TypesOfAction
{
    public class ExecutionAction
    {
        public static bool ExecuteAction(Models.Action action, Hero player, Hero target)
        {
            IExecution execution = (IExecution)action;
            return execution.IsExecutionPossible(target);
        }

    }
}
