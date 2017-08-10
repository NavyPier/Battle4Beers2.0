using System;
using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;

namespace Battle4Beers.Client.Models.Actions
{
    public class AmplifyMagic : Buff
    {
        private int amplifier;

        public AmplifyMagic(string name, int coolDown, int cost, int duration, int amplifier) : base(name, coolDown, cost, duration)
        {
            this.Amplifier = amplifier;
        }

        public int Amplifier
        {
            get { return this.amplifier; }
            protected set { this.amplifier = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: Makes the player deal {this.Amplifier}% more damage for the next {this.Duration} turns. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
