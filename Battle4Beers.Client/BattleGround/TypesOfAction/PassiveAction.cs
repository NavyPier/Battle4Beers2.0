using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Models;
using System;

namespace Battle4Beers.Client.BattleGround
{
    public class PassiveAction
    {
        public static void ExecuteAction(Models.Action action, Hero player)
        {
            FrostMage warr = (FrostMage)player;
            Console.WriteLine(warr.FrostArmored);
            IPassiveActivator hero = (IPassiveActivator)player;
            hero.ActivatePassive(action.Name, player);
            Console.WriteLine(warr.IcyVeins);
        }
    }
}
