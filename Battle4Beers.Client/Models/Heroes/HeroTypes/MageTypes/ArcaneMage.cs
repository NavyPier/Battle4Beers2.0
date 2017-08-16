using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Models.Actions;
using Battle4Beers.Client.Utilities.Constants;
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

        public int PassiveDuration { get; set; }

        public void ActivatePassive(string nameOfPassive, Hero player)
        {
            if(nameOfPassive == "AMPLIFY MAGIC")
            {
                this.IsAmplified = true;
                this.PassiveDuration = AbilityDurationConstants.AmplifierDuration;
                player.Actions.First(a => a.Name == nameOfPassive).SetCooldown(AbilityCooldownConstants.AmplifyMagicCooldown);
                ArcaneBlast arcaneBlast = player.Actions[0] as ArcaneBlast;
            }
            else
            {
                this.Mana += AbilityConstants.ArcaneMageManaRegeneration;
                this.PassiveDuration--;
                player.Actions.First(a => a.Name == nameOfPassive).SetCooldown(AbilityCooldownConstants.ManaRegenerationCooldown);
            }

            if(this.PassiveDuration <= 0)
            {
                this.isAmplified = false;
            }
        }
    }
}
