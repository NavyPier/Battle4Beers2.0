using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Models;
using Battle4Beers.Client.Utilities.Constants;
using System;

namespace Battle4Beers.Client.BattleGround
{
    public class PassiveAction
    {
        public static void ExecuteAction(Models.Action action, Hero player)
        {
            if (action.Name != "CRITICAL STRIKE")
            {
                HeroCooldownReductor.ReduceCooldowns(player);
                IPassiveActivator hero = (IPassiveActivator)player;
                hero.ActivatePassive(action.Name, player);
                ActionResult.ShowActionResult($"{player.Name} ACTIVATED {action.Name}!");
            }
            else
            {
                SwordmasterWarrior swordmaster = (SwordmasterWarrior)player;
                if (swordmaster.CriticalStrike)
                {
                    var key = new ConsoleKeyInfo();
                    while (key.Key != ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Constants.GameTitle);
                        Console.WriteLine($"CRITICAL STRIKE HAS ALREADY BEEN LEVELED UP! SELECT DIFFERENT ACTION!");
                        Console.WriteLine("-- PRESS ENTER TO CONTINUE TO ACTION MENU --");
                        key = Console.ReadKey();
                    }
                    Combat.PlayerTurn(player);
                }
                else
                {
                    HeroCooldownReductor.ReduceCooldowns(player);
                    IPassiveActivator hero = (IPassiveActivator)player;
                    hero.ActivatePassive(action.Name, player);
                    ActionResult.ShowActionResult($"{player.Name} ACTIVATED {action.Name}!");
                }
            }

        }
    }
}
