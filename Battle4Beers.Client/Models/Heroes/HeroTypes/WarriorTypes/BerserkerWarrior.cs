using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System.Collections.Generic;
using System.Linq;

namespace Battle4Beers.Client.Models
{
    public class BerserkerWarrior : Warrior, IPassiveActivator
    {
        public BerserkerWarrior(string name, int health, int healthRegen, List<Action> actions, int armor, int rage, int attackPower) : base(name, health, healthRegen, actions, armor, rage, attackPower)
        {
            this.IsBerserk = false;
        }

        public bool IsBerserk { get; set; }

        public int PassiveDuration { get; set; }

        public void ActivatePassive(string nameOfPassive, Hero player)
        {
            if(player.Health > AbilityConstants.BerserkModeCost)
            {
                BerserkerWarrior warr = (BerserkerWarrior)player;
                warr.IsBerserk = true;
                warr.TakeDamage(AbilityConstants.BerserkModeCost);
                this.PassiveDuration = AbilityDurationConstants.BerserkDuration;
                player.Actions.First(a => a.Name == nameOfPassive).SetCooldown(AbilityCooldownConstants.GoBerserkCooldown);
            }
            else
            {
                System.Console.WriteLine("PLAYER'S HP IS TOO LOW TO USE THIS ACTION!");
                ActionManager.Pause(3);
                Combat.PlayerTurn(player);
            }

        }

        public void DeactivatePassive(string nameOfPassive)
        {
            this.IsBerserk = false;
        }
    }
}
