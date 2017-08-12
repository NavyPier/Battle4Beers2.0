using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Text;

namespace Battle4Beers.Client.Models.Actions.PriestActions.ShadowPriest
{
    public class Sadism : Action
    {
        private int percentage;
        private int healingPercentage;
        
        public Sadism(string name, int coolDown, int cost, int percentage, int healingPercentage) : base(name, coolDown, cost)
        {
            this.Percentage = percentage;
            this.HealingPercentage = healingPercentage;
            this.Type = "passive";
        }

        public int Percentage
        {
            get { return this.percentage; }
            protected set { this.percentage = value;}
        }

        public int HealingPercentage
        {
            get { return this.HealingPercentage; }
            protected set { this.healingPercentage = value; }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Name}: Makes the player deal {this.Percentage}% more damage for the next {AbilityDurationConstants.SadismDuration} turns.");
            sb.AppendLine($"The player heals for {this.HealingPercentage}% of his damage dealt. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana");
            return sb.ToString().Trim();
        }

        
    }
}
