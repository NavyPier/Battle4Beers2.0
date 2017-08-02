namespace Battle4Beers.Client.Models.Actions.WarriorActions
{
    using Interfaces;
    using Utilities.Constants;

    public class Hibernate : Action, IBuff
    {
        private int duration;
        private int heal;
        private int percentage;

        public Hibernate(string name, int coolDown, int cost, int heal, int duration) : base(name, coolDown, cost)
        {
            this.Heal = heal;
            this.Duration = duration;
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

        public int Duration
        {
            get { return this.duration; }
            protected set { this.duration = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: {Constants.DamageReductionString} {Constants.HealingString} {Constants.CooldownAndCost}";
        }

    }
}
