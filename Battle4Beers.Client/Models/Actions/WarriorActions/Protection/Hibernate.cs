namespace Battle4Beers.Client.Models.Actions.WarriorActions
{
    public class Hibernate : Buff
    {
        private int heal;
        private int percentage;

        public Hibernate(string name, int coolDown, int cost, int duration, int heal) : base(name, coolDown, cost, duration)
        {
            this.Heal = heal;
            this.Percentage = 50;
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
            return $"{this.Name}: Buff target ally to receive only {this.Percentage}% damage for the next {this.Duration} turns. Heal target ally for {this.Heal}. Cooldown: {this.CoolDown}, Cost: {this.Cost}";
        }

    }
}
