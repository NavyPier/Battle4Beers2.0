using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
