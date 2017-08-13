using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System.Collections.Generic;
using System.Linq;

namespace Battle4Beers.Client.Models
{
    public class FireMage : Mage, IPassiveActivator
    {
        private bool fireArmored;

        public FireMage(string name, int health, int healthRegen, List<Action> actions, int armor, int mana, int manaRegen, int spellPower) : base(name, health, healthRegen, actions, armor, mana, manaRegen, spellPower)
        {
            this.FireArmored = false;
        }

        public bool FireArmored
        {
            get { return fireArmored; }
            set { fireArmored = value; }
        }

        public int PassiveDuration { get; set; }

        public void ActivatePassive(string nameOfPassive, Hero player)
        {
            this.PassiveDuration = AbilityDurationConstants.FireArmorDuration;
            this.FireArmored = true;
            player.Actions.Where(a => a.Name == nameOfPassive).First().SetCooldown(AbilityCooldownConstants.FireArmorCooldown);
        }

        public void DeactivatePassive(string nameOfPassive)
        {
            this.FireArmored = false;
        }
    }
}
