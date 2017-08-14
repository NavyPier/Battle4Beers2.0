using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System.Collections.Generic;
using System.Linq;

namespace Battle4Beers.Client.Models
{
    public class FrostMage : Mage, IPassiveActivator
    {
        public FrostMage(string name, int health, int healthRegen, List<Action> actions, int armor, int mana, int manaRegen, int spellPower) : base(name, health, healthRegen, actions, armor, mana, manaRegen, spellPower)
        {
            this.IcyVeins = false;
            this.FrostArmored = false;
        }

        public bool FrostArmored
        {
            get;
            set;
        }

        public bool IcyVeins
        {
            get;
            set;
        }

        public int FrostArmorDuration
        {
            get; set;
        }

        public int IcyVeinsDuration
        {
            get; set;
        }

        public int PassiveDuration
        {
            get;
        }

        public void ActivatePassive(string nameOfPassive, Hero player)
        {
            if (nameOfPassive == "ICY VEINS")
            {
                this.IcyVeins = true;
                this.IcyVeinsDuration = AbilityDurationConstants.IcyVeinsDuration;
                this.FrostArmorDuration--;
                player.Actions.First(a => a.Name == nameOfPassive).SetCooldown(AbilityCooldownConstants.IcyVeinsCooldown);
            }
            else
            {
                this.FrostArmorDuration = AbilityDurationConstants.FrostArmorDuration;
                this.FrostArmored = true;
                this.IcyVeinsDuration--;
                player.Actions.First(a => a.Name == nameOfPassive).SetCooldown(AbilityCooldownConstants.FrostArmorCooldown);
            }

            if (this.FrostArmorDuration <= 0)
            {
                this.FrostArmored = false;
            }

            if (this.IcyVeinsDuration <= 0)
            {
                this.IcyVeins = false;
            }
        }

        public override void TakeDamage(int amount)
        {
            if(this.FrostArmored)
            {
                this.Health -= (int)(amount * 0.8);
            }
            else
            {
                this.Health -= amount;
            }
        }

        public void DeactivatePassive(string nameOfPassive)
        {
            if (nameOfPassive == "ICY VEINS")
            {
                this.IcyVeins = false;
            }
            else
            {
                this.FrostArmored = false;
            }
        }
    }
}
