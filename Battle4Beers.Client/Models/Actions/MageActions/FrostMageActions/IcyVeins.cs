using Battle4Beers.Client.Utilities.Constants;
using System;

namespace Battle4Beers.Client.Models.Actions
{
    public class IcyVeins : Action
    {
        private double amplifier;

        public IcyVeins(string name, int coolDown, int cost, double amplifier) : base(name, coolDown, cost)
        {
            this.Amplifier = amplifier;
            this.Type = "passive";
        }

        public double Amplifier
        {
            get { return this.amplifier; }
            protected set { this.amplifier = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: Makes the player deal {this.Amplifier}% more damage for the next {AbilityDurationConstants.IcyVeinsDuration} turns. Lowers remaining cooldown on all used spells by 1. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
