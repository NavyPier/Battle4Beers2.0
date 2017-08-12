using Battle4Beers.Client.Models;
using System;

namespace Battle4Beers.Client.BattleGround
{
    public class CriticalChecker
    {
        public static bool CheckForCrit(Hero player)
        {
            var typeOfWarr = player.GetType().Name;

            if(typeOfWarr == "SwordmasterWarrior")
            {
                SwordmasterWarrior warr = (SwordmasterWarrior)player;
                if(warr.CriticalStrike)
                {
                    var chance = new Random().Next(1, 101);
                    return chance <= 35;
                }
            }
            else if(typeOfWarr == "BerserkerWarrior")
            {
                    var chance = new Random().Next(1, 101);
                    return chance <= 15;
            }

            return false;
        }

    }
}
