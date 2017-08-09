using Battle4Beers.Client.Models;
using System.Collections.Generic;

namespace Battle4Beers.Client
{
    public class Combat
    {
        public static void ArrangeTeams(List<Hero> players)
        {
            if(players.Count == 2)
            {
                var firstTeam = new List<Hero> { players[0] };
                var secondTeam = new List<Hero> { players[1] };
                Battle(firstTeam, secondTeam);
            }
            else
            {
                var firstTeam = new List<Hero> { players[0], players[1] };
                var secondTeam = new List<Hero> { players[2], players[3] };
                Battle(firstTeam, secondTeam);
            }
        }
        
        public static void Battle(List<Hero> firstTeam, List<Hero> secondTeam)
        {
            while(firstTeam.Count > 0 && secondTeam.Count > 0)
            {
                var playerIsOnTurn = true;

                while(playerIsOnTurn)
                {
                    
                }
            }

        }
    }
}
