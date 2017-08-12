using System;
using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;

namespace Battle4Beers.Client.Models.Actions
{
    public class AmplifyMagic : Action
    {
        private int amplifier;

        public AmplifyMagic(string name, int coolDown, int cost) : base(name, coolDown, cost)
        {
            this.Type = "passive";
        }

        public int Amplifier
        {
            get { return this.amplifier; }
            protected set { this.amplifier = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: Makes the player deal {this.Amplifier}% more damage for the next {AbilityDurationConstants.AmplifierDuration} turns. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
