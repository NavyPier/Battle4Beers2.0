using System;
using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;

namespace Battle4Beers.Client.Models.Actions.FrostMage
{
    public class FrostArmor : Action, IBuff
    {
        private int armor;
        private int duration;
        private int percentage;

        public FrostArmor(string name, int coolDown, int cost, int armor, int percentage, int duration) : base(name, coolDown, cost)
        {
            this.Armor = armor;
            this.Percentage = percentage;
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

        public int Duration
        {
            get
            {
                return this.duration;
            }
            protected set
            {
                this.duration = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}: Give {this.Armor} to target. Buff target ally to receive only {this.Percentage}% damage for the next {this.Duration} turns. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
