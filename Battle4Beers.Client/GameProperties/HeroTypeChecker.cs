using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Models;
using System;

namespace Battle4Beers.Client.GameProperties
{
    public class HeroTypeChecker
    {
        public static bool CheckForPassive(Hero player)
        {
            var typeOfHero = player.GetType();
            var currentInterfaces = typeOfHero.GetInterfaces();
            foreach(var currentInterface in currentInterfaces)
            {
                if(currentInterface.Name == "IPassiveActivator")
                {
                   return GetClassTypePassive(typeOfHero, player);
                }
            }
            return false;
        }

        private static bool GetClassTypePassive(Type typeOfHero, Hero player)
        {
            switch (typeOfHero.Name)
            {
                case "BerserkerWarrior":
                    BerserkerWarrior berserker = (BerserkerWarrior)player;
                    return berserker.IsBerserk;
                case "FrostMage":
                    FrostMage frost = (FrostMage)player;
                    return frost.IcyVeins;
                case "ArcaneMage":
                    ArcaneMage arcane = (ArcaneMage)player;
                    return arcane.IsAmplified;
                case "ShadowPriest":
                    ShadowPriest shadowPriest = (ShadowPriest)player;
                    return shadowPriest.Sadist;
                default: return false;
            }
        }

        public static bool CheckHeroClass(Hero player, Models.Action action)
        {
            var typeOfHero = player.GetType();
            var currentInterfaces = typeOfHero.GetInterfaces();
            foreach (var currentInterface in currentInterfaces)
            {
                if (currentInterface.Name == "ICaster")
                {
                    ICaster caster = (ICaster)player;
                    if(caster.Mana >= action.Cost)
                    {
                        player.ExecuteAction(action.Cost);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if(currentInterface.Name == "IFighter")
                {
                    IFighter figher = (IFighter)player;
                    if(figher.Rage >= action.Cost)
                    {
                        player.ExecuteAction(action.Cost);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public static string[] GetHeroEnergyTypeAndAmount(Hero player)
        {
            var typeOfHero = player.GetType();
            var currentInterfaces = typeOfHero.GetInterfaces();
            foreach (var currentInterface in currentInterfaces)
            {
                if (currentInterface.Name == "ICaster")
                {
                    ICaster caster = (ICaster)player;
                    return new string[] { "MANA", $"{caster.Mana}"};
                }
                else if (currentInterface.Name == "IFighter")
                {
                    IFighter fighter = (IFighter)player;
                    return new string[] { "RAGE", $"{fighter.Rage}" };
                }
            }
            return new string[0];
        }
    }
}
