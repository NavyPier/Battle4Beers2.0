using Battle4Beers.Client.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Battle4Beers.Client.Utilities.Constants;
using Battle4Beers.Client.BattleGround;
using Battle4Beers.Client.GameProperties;

namespace Battle4Beers.Client
{
    public class Combat
    {
        public static List<Hero> firstTeam;
        public static List<Hero> secondTeam;

        public static int Count { get; private set; }

        public static void ArrangeTeams(List<Hero> players)
        {
            if (players.Count == 2)
            {
                firstTeam = new List<Hero> { players[0] };
                secondTeam = new List<Hero> { players[1] };
                BattleStart(firstTeam, secondTeam);
            }
            else
            {
                firstTeam = new List<Hero> { players[0], players[1] };
                secondTeam = new List<Hero> { players[2], players[3] };
                BattleStart(firstTeam, secondTeam);
            }
        }

        public static void BattleStart(List<Hero> firstTeam, List<Hero> secondTeam)
        {
            while (firstTeam.Where(a => a.Health >0).ToList().Count > 0 && secondTeam.Where(a => a.Health > 0).ToList().Count > 0)
            {
                CheckPlayerHealth(firstTeam[0]);
                CheckPlayerHealth(secondTeam[0]);
                if (firstTeam.Count == 2)
                {
                    CheckPlayerHealth(firstTeam[1]);
                }
                if (secondTeam.Count == 2)
                {
                    CheckPlayerHealth(secondTeam[1]);
                }

                foreach (var player in firstTeam)
                {
                    player.Regenerate();
                }

                foreach (var player in secondTeam)
                {
                    player.Regenerate();
                }
            }
            GameResult.GetResult(firstTeam, secondTeam);
        }

        private static void CheckPlayerHealth(Hero player)
        {
            if (player.Buffs.Count > 0)
            {
                foreach (var buff in player.Buffs)
                {
                    buff.BuffPlayer(player);
                }
            }

            player.Buffs.RemoveAll(a => a.Duration <= 0);

            if (player.Debuffs.Count > 0)
            {
                foreach (var debuff in player.Debuffs)
                {
                    debuff.DebuffPlayer(player);
                }
            }

            player.Debuffs.RemoveAll(a => a.Duration <= 0);

            PlayerTurn(player);
        }

        public static void PlayerTurn(Hero player)
        {
            if (player.StunnedDuration <= 0 && player.Health > 0)
            {
                var action = TypesOfMenu.ActionsMenu(player);
                while (!CheckForEnoughManaOrRage(player, action) || action.IsOnCooldown())
                {
                    var key = new ConsoleKeyInfo();
                    while (key.Key != ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Constants.GameTitle);
                        if (action.IsOnCooldown())
                        {
                            Console.WriteLine($"{action.Name} is on cooldown right now! Select a different action!");
                        }
                        else if (!CheckForEnoughManaOrRage(player, action))
                        {
                            Console.WriteLine($"{action.Name} CANNOT BE CAST DUE TO INSUFFICIENT ENERGY!");
                        }
                        Console.WriteLine("-- PRESS ENTER TO CONTINUE TO ACTION MENU --");
                        key = Console.ReadKey();
                    }
                    action = TypesOfMenu.ActionsMenu(player);
                }
                ActionGetter.GetTypeOfAction(action, player, firstTeam, secondTeam);
            }
            else if (player.Health > 0)
            {
                var key = new ConsoleKeyInfo();
                while (key.Key != ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Constants.GameTitle);
                    Console.WriteLine($"{player.Name} is stunned right now. Proceeding to next player");
                    Console.WriteLine("-- PRESS ENTER TO CONTINUE TO NEXT PLAYER --");
                    key = Console.ReadKey();
                }
                player.StunnedDuration--;
            }
        }

        private static bool CheckForEnoughManaOrRage(Hero player, Models.Action action)
        {
            return HeroTypeChecker.CheckHeroClass(player, action);
        }
    }
}
