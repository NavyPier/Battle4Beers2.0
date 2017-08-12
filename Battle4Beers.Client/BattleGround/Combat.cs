using Battle4Beers.Client.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Battle4Beers.Client.Utilities.Constants;
using Battle4Beers.Client.BattleGround;

namespace Battle4Beers.Client
{
    public class Combat
    {
        public static bool arenaBattle = false;
        public static bool duelBattle = false;
        public static List<Hero> firstTeam;
        public static List<Hero> secondTeam;

        public static void ArrangeTeams(List<Hero> players)
        {
            if (players.Count == 2)
            {
                duelBattle = true;
                firstTeam = new List<Hero> { players[0] };
                secondTeam = new List<Hero> { players[1] };
                Battle(firstTeam, secondTeam);
            }
            else
            {
                arenaBattle = true;
                firstTeam = new List<Hero> { players[0], players[1] };
                secondTeam = new List<Hero> { players[2], players[3] };
                Battle(firstTeam, secondTeam);
            }
        }

        public static void Battle(List<Hero> firstTeam, List<Hero> secondTeam)
        {
            while (firstTeam.Count > 0 && secondTeam.Count > 0)
            {
                CheckIfStunned(firstTeam[0]);
                CheckIfStunned(secondTeam[0]);
                if (firstTeam.Count == 2)
                {
                    CheckIfStunned(firstTeam[1]);
                }
                if (secondTeam.Count == 2)
                {
                    CheckIfStunned(secondTeam[1]);
                }
            }
        }

        public static void CheckIfStunned(Hero player)
        {
            if (player.StunnedDuration <= 0)
            {
                var action = TypesOfMenu.ActionsMenu(player);
                ActionGetter.GetTypeOfAction(action, player, firstTeam, secondTeam);
            }
            else
            {
                var key = new ConsoleKeyInfo();
                while (key.Key != ConsoleKey.Enter)
                {
                    Console.WriteLine($"{player.Name} is stunned right now. Proceeding to next player");
                    Console.WriteLine("-- PRESS ENTER TO CONTINUE TO NEXT PLAYER --");
                    Console.Clear();
                    Console.ReadKey();
                }
                player.StunnedDuration--;
            }
        }
    }
}
