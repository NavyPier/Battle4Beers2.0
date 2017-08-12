using Battle4Beers.Client.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Battle4Beers.Client.BattleGround
{
    public class GameResult
    {
        public static void GetResult(List<Hero> firstTeam, List<Hero> secondTeam)
        {
            var arenaBattle = firstTeam.Count == 2 ? true : false;
            List<Hero> winningTeam;
            List<Hero> losingTeam;

            if (arenaBattle)
            {
                if (firstTeam.Where(a => a.Health <= 0).ToList().Count == 2)
                {
                    winningTeam = secondTeam;
                    losingTeam = firstTeam;
                }
                else
                {
                    winningTeam = firstTeam;
                    losingTeam = secondTeam;
                }
            }
            else
            {
                if (firstTeam[0].Health <= 0)
                {
                    winningTeam = secondTeam;
                    losingTeam = firstTeam;
                }
                else
                {
                    winningTeam = firstTeam;
                    losingTeam = secondTeam;
                }
            }

            ZapishetePobediteliteKolegi(winningTeam, losingTeam);
        }

        private static void ZapishetePobediteliteKolegi(List<Hero> winningTeam, List<Hero> losingTeam)
        {
            throw new NotImplementedException();
        }
    }
}
