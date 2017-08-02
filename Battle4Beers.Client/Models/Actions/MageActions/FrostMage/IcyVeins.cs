using System;
using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;

namespace Battle4Beers.Client.Models.Actions.FrostMage
{
    public class IcyVeins : Action, IBuff
    {
        private double amplifier;
        private int duration;

        public IcyVeins(string name, int coolDown, int cost, double amplifier, int duration) : base(name, coolDown, cost)
        {
            this.Amplifier = amplifier;
            this.Duration = duration;
        }

        public double Amplifier
        {
            get { return this.amplifier; }
            protected set { this.amplifier = value; }
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
            return $"{this.Name}: {Constants.DamageAmplifierString} Lowers remaining cooldown on all used spells by 1 for you and your allies. {Constants.CooldownAndCost} Mana";
        }
    }
}
