using Battle4Beers.Client.Utilities.Constants;

namespace Battle4Beers.Client.Models.Actions.WarriorActions
{
    public class Hibernate : Action
    {
        private int heal;
        private int percentage;

        public Hibernate(string name, int coolDown, int cost, int heal) : base(name, coolDown, cost)
        {
            this.Heal = heal;
            this.Percentage = 50;
            this.Type = "passive";
        }

        public int Percentage
        {
            get { return percentage; }
            protected set { percentage = value; }
        }

        public int Heal
        {
            get { return this.heal; }
            protected set { this.heal = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: Buff target ally to receive only {this.Percentage}% damage for the next {AbilityDurationConstants.HibernateDuration} turns. Heal target ally for {this.Heal}. Cooldown: {this.CoolDown}, Cost: {this.Cost}";
        }
    }
}
