using Battle4Beers.Client.Models;
using System.Collections.Generic;

namespace Battle4Beers.Client.BattleGround
{
    public class TargetTeamGetter
    {
        public static List<Hero> GetEnemies(Hero player, List<Hero> firstTeam, List<Hero> secondTeam)
        {
            if (firstTeam.Contains(player))
            {
                return secondTeam;
            }
            else
            {
                return firstTeam;
            }
        }

        public static List<Hero> GetAllies(Hero player, List<Hero> firstTeam, List<Hero> secondTeam)
        {
            if (firstTeam.Contains(player))
            {
                return firstTeam;
            }
            else
            {
                return secondTeam;
            }
        }
    }
}
