using Battle4Beers.Client.Utilities.Constants;
using System;

namespace Battle4Beers.Client.Models.Actions.FrostMage
{
    public class FrostArmor : Action
    {
        private int armor;
        private int percentage;

        public FrostArmor(string name, int coolDown, int cost, int armor, int percentage) : base(name, coolDown, cost)
        {
            this.Armor = armor;
            this.Percentage = percentage;
            this.Type = "passive";
        }

        public int Percentage
        {
            get { return this.percentage; }
            protected set { this.percentage = value; }
        }

        public int Armor
        {
            get
            {
                return this.armor;
            }
            protected set
            {
                this.armor = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}: Give {this.Armor} to target. Buff target ally to receive only {this.Percentage}% damage for the next {AbilityDurationConstants.FrostArmorDuration} turns. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }

        public int ReduceDamage(int initialDamage)
        {
            return (int) (initialDamage * 0.8);
        }
    }
}
