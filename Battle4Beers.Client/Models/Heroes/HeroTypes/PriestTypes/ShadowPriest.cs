using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Battle4Beers.Client.Models
{
    public class ShadowPriest : Priest, IPassiveActivator
    {
        private bool sadist;

        public ShadowPriest(string name, int health, int healthRegen, List<Action> actions, int armor, int mana, int manaRegen, int spellPower) : base(name, health, healthRegen, actions, armor, mana, manaRegen, spellPower)
        {
            this.Sadist = false;
        }

        public int PassiveDuration
        {
            get
            {
                return this.PassiveDuration;
            }
            set { this.PassiveDuration = value; }
        }

        public bool Sadist
        {
            get { return this.sadist; }
            set { this.sadist = value; }
        }

        public void ActivatePassive(string nameOfPassive, Hero player)
        {
            ShadowPriest priest = (ShadowPriest)player;
            priest.Sadist = true;
            this.PassiveDuration = AbilityDurationConstants.SadismDuration;
            player.Actions.Where(a => a.Name == nameOfPassive).First().SetCooldown(AbilityCooldownConstants.SadismCooldown);
        }

        public void DeactivatePassive(string nameOfPassive)
        {
            this.Sadist = false;
        }
    }
}
