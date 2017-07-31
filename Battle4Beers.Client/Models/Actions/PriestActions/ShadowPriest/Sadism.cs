using System;
using Battle4Beers.Client.Interfaces;

namespace Battle4Beers.Client.Models.Actions.PriestActions.ShadowPriest
{
    public class Sadism : Action, IBuff
    {
        private double amplifier;
        private double healingPercentage;
        private int duration;
        
        public Sadism(string name, int coolDown, int cost, double amplifier, double percentageHeal, int duration) : base(name, coolDown, cost)
        {

        }

        public double Amplifier
        {
            get { return this.amplifier; }
            protected set { this.amplifier = value;}
        }

        public double HealingPercentage
        {
            get { return this.HealingPercentage; }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            protected set { this.duration = value; }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
