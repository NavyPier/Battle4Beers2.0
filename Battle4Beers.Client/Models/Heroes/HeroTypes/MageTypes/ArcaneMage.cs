using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Models.Actions;
using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Battle4Beers.Client.Models
{
    public class ArcaneMage : Mage, IPassiveActivator
    {
        private bool isAmplified;

        public ArcaneMage(string name, int health, int healthRegen, List<Action> actions, int armor, int mana, int manaRegen, int spellPower) : base(name, health, healthRegen, actions, armor, mana, manaRegen, spellPower)
        {
            this.IsAmplified = false;
        }

        public bool IsAmplified
        {
            get { return this.isAmplified; }
            set { this.isAmplified = value; }
        }

        public int PassiveDuration
        {
            get { return this.PassiveDuration; }
            set
            {
                this.PassiveDuration = value ;
            }
        }

        public void ActivatePassive(string nameOfPassive, Hero player)
        {
            if(nameOfPassive == "AMPLIFY MAGIC")
            {
                this.IsAmplified = true;
                this.PassiveDuration = AbilityDurationConstants.AmplifierDuration;
                player.Actions.Where(a => a.Name == nameOfPassive).First().SetCooldown(AbilityCooldownConstants.AmplifyMagicCooldown);
            }
            else
            {
                this.Mana += AbilityConstants.ArcaneMageManaRegeneration;
                player.Actions.Where(a => a.Name == nameOfPassive).First().SetCooldown(AbilityCooldownConstants.ManaRegenerationCooldown);

            }

        }

        public void DeactivatePassive(string nameOfPassive)
        {
            this.IsAmplified = false;
        }
    }
}
