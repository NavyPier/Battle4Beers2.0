using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Battle4Beers.Client.Models
{
    public class FrostMage : Mage, IPassiveActivator
    {
        private bool icyVeins;
        private bool frostArmored;

        public FrostMage(string name, int health, int healthRegen, List<Action> actions, int armor, int mana, int manaRegen, int spellPower) : base(name, health, healthRegen, actions, armor, mana, manaRegen, spellPower)
        {
            this.IcyVeins = false;
            this.FrostArmored = false;
        }

        public bool FrostArmored
        {
            get { return this.frostArmored; }
            set { this.frostArmored = value; }
        }

        public bool IcyVeins
        {
            get { return icyVeins; }
            protected set { icyVeins = value; }
        }

        public int FrostArmorDuration
        {
            get
            {
                return this.FrostArmorDuration;
            }
            set { this.FrostArmorDuration = value; }
        }

        public int IcyVeinsDuration
        {
            get
            {
                return this.IcyVeinsDuration;
            }
            set { this.IcyVeinsDuration = value; }
        }

        public int PassiveDuration
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void ActivatePassive(string nameOfPassive, Hero player)
        {
            if(nameOfPassive == "ICY VEINS")
            {
                this.IcyVeins = true;
                this.IcyVeinsDuration = AbilityDurationConstants.IcyVeinsDuration;
                player.Actions.Where(a => a.Name == nameOfPassive).First().SetCooldown(AbilityCooldownConstants.IcyVeinsCooldown);
            }
            else
            {
                this.FrostArmorDuration = AbilityDurationConstants.FrostArmorDuration;
                this.FrostArmored = true;
                player.Actions.Where(a => a.Name == nameOfPassive).First().SetCooldown(AbilityCooldownConstants.FrostArmorCooldown);
            }
        }

        public void DeactivatePassive(string nameOfPassive)
        {
            if(nameOfPassive == "ICY VEINS")
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
