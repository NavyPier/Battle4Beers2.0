namespace Battle4Beers.Client.Models.Actions.WarriorActions
{
    using Interfaces;
    public class Hibernate : Action, IBuff
    {
        private int duration;
        private int heal;

        public Hibernate(string name, int coolDown, int cost, int heal, int duration) : base(name, coolDown, cost)
        {
            this.Heal = heal;
            this.Duration = duration;
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
            throw new System.NotImplementedException();
        }

    }
}
