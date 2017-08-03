namespace Battle4Beers.Client.Models.Actions.PriestActions.ShadowPriest
{
    public class Sadism : Buff
    {
        private double percentage;
        private double healingPercentage;
        
        public Sadism(string name, int coolDown, int cost, int duration, double percentage, double healingPercentage) : base(name, coolDown, cost, duration)
        {
            this.Percentage = percentage;
            this.HealingPercentage = healingPercentage;
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
        
        public override string ToString()
        {
            return $"{this.Name}: Makes the player deal {this.Percentage}% more damage for the next {this.Duration} turns. The player heals for {this.HealingPercentage}% of his damage dealt. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
