using System;

namespace Battle4Beers.Client.Models.Actions.FrostMage
{
    public class IcyVeins : Buff
    {
        private double amplifier;

        public IcyVeins(string name, int coolDown, int cost, int duration, double amplifier) : base(name, coolDown, cost, duration)
        {
            this.Amplifier = amplifier;
        }

        public double Amplifier
        {
            get { return this.amplifier; }
            protected set { this.amplifier = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: Makes the player deal {this.Amplifier}% more damage for the next {this.Duration} turns. Lowers remaining cooldown on all used spells by 1. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
