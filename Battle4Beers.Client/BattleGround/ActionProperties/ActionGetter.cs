using Battle4Beers.Client.BattleGround.TypesOfAction;
using Battle4Beers.Client.Models;
using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Battle4Beers.Client.BattleGround
{
    public class ActionGetter
    {
        public static void GetTypeOfAction(Models.Action action, Hero player, List<Hero> firstTeam, List<Hero> secondTeam)
        {
            if (action.Type == "friendly")
            {
                var allyTeam = TargetTeamGetter.GetAllies(player, firstTeam, secondTeam);
                if(allyTeam.Where(a => a.Health > 0).ToList().Count > 1)
                {
                    Hero target = ChooseTarget(allyTeam);
                    FriendlyAction.ExecuteAction(action, player, target);
                }
                else
                {
                    Hero target = allyTeam.Where(a => a.Health > 0).First();
                    FriendlyAction.ExecuteAction(action, player, target);
                }
            }
            else if (action.Type == "agressive")
            {
                var enemyTeam = TargetTeamGetter.GetEnemies(player, firstTeam, secondTeam);
                if (enemyTeam.Where(a => a.Health > 0).ToList().Count > 1)
                {
                    Hero target = ChooseTarget(enemyTeam);
                    AgressiveAction.ExecuteAction(action, player, target);
                }
                else
                {
                    Hero target = enemyTeam.Where(a => a.Health > 0).First();
                    AgressiveAction.ExecuteAction(action, player, target);
                }
            }
            else if(action.Type == "passive")
            {
                PassiveAction.ExecuteAction(action, player);
            }
            else if(action.Type == "buff")
            {
                var allyTeam = TargetTeamGetter.GetAllies(player, firstTeam, secondTeam);
                if (allyTeam.Where(a => a.Health > 0).ToList().Count > 1)
                {
                    Hero target = ChooseTarget(allyTeam);
                    BuffAction.ExecuteAction(action, player, target);
                }
                else
                {
                    Hero target = allyTeam.Where(a => a.Health > 0).First();
                    BuffAction.ExecuteAction(action, player, target);
                }
            }
            else if(action.Type == "debuff")
            {
                var enemyTeam = TargetTeamGetter.GetEnemies(player, firstTeam, secondTeam);
                if (enemyTeam.Where(a => a.Health > 0).ToList().Count > 1)
                {
                    Hero target = ChooseTarget(enemyTeam);
                    DebuffAction.ExecuteAction(action, player, target);
                }
                else
                {
                    Hero target = enemyTeam.Where(a => a.Health > 0).First();
                    DebuffAction.ExecuteAction(action, player, target);
                }
            }
            else if (action.Type == "execution")
            {
                var enemyTeam = TargetTeamGetter.GetEnemies(player, firstTeam, secondTeam);
                bool isExecuted;
                Hero target;
                if (enemyTeam.Where(a => a.Health > 0).ToList().Count > 1)
                {
                    target = ChooseTarget(enemyTeam);
                    isExecuted = ExecutionAction.ExecuteAction(action, player, target);
                }
                else
                {
                    target = enemyTeam.Where(a => a.Health > 0).First();
                    isExecuted = ExecutionAction.ExecuteAction(action, player, target);
                }

                if(isExecuted)
                {
                    HeroCooldownReductor.ReduceCooldowns(player);
                    target.TakeDamage(AbilityConstants.ExecutionDamage);
                    var key = new ConsoleKeyInfo();
                    while (key.Key != ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Constants.GameTitle);
                        Console.WriteLine($"{target.Name} HAS BEEN BRUTALLY EXECUTED!");
                        Console.WriteLine("-- PRESS ENTER TO CONTINUE TO ACTION MENU TO SELECT A DIFFERENT ACTION --");
                        key = Console.ReadKey();
                    }
                }
                else
                {
                    var key = new ConsoleKeyInfo();
                    while (key.Key != ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Constants.GameTitle);
                        Console.WriteLine($"{target.Name}'S HEALTH IS NOT LOW ENOUGH TO BE EXECUTED!");
                        Console.WriteLine("-- PRESS ENTER TO CONTINUE TO ACTION MENU TO SELECT A DIFFERENT ACTION --");
                        key = Console.ReadKey();
                    }
                    Combat.PlayerTurn(player);
                }
                
            }

        }

        private static Hero ChooseTarget(List<Hero> currentTeam)
        {
            return TypesOfMenu.SelectATarget(currentTeam);
        }
    }
}
