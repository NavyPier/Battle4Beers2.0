using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Battle4Beers.Client.Models
{
    public class BerserkerWarrior : Warrior, IPassiveActivator
    {
        private bool isBerserk;

        public BerserkerWarrior(string name, int health, int healthRegen, List<Action> actions, int armor, int rage, int attackPower) : base(name, health, healthRegen, actions, armor, rage, attackPower)
        {
            this.IsBerserk = false;
        }

        public bool IsBerserk
        {
            get { return this.isBerserk; }
            set { this.isBerserk = value; }
        }

        public int PassiveDuration
        {
            get
            {
                return this.PassiveDuration;
            }
            set { this.PassiveDuration = value; }
        }

        public void ActivatePassive(string nameOfPassive, Hero player)
        {
            BerserkerWarrior warr = (BerserkerWarrior)player;
            warr.IsBerserk = true;
            warr.GetDamaged(AbilityConstants.BerserkModeCost);
            this.PassiveDuration = AbilityDurationConstants.BerserkDuration;
            player.Actions.Where(a => a.Name == this.Name).First().SetCooldown(AbilityCooldownConstants.GoBerserkCooldown);
        }

        public void DeactivatePassive(string nameOfPassive)
        {
            this.IsBerserk = false;
        }
    }
}
