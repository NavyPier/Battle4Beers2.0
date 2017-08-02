using System;
using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;

namespace Battle4Beers.Client.Models.Actions.PriestActions.ShadowPriest
{
    public class Sadism : Action, IBuff
    {
        private double percentage;
        private double healingPercentage;
        private int duration;
        
        public Sadism(string name, int coolDown, int cost, double percentage, double healingPercentage, int duration) : base(name, coolDown, cost)
        {
            this.Percentage = percentage;
            this.HealingPercentage = healingPercentage;
            this.Duration = duration;
        }

        public double Percentage
        {
            get { return this.percentage; }
            protected set { this.percentage = value;}
        }

        public double HealingPercentage
        {
            get { return this.HealingPercentage; }
            protected set { this.healingPercentage = value; }
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
            return $"{this.Name}: Makes the player deal {this.Percentage}% more damage for the next {this.Duration} turns. The player heals for {this.HealingPercentage}% of his damage dealt. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
