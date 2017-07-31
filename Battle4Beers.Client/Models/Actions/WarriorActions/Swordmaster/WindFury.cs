namespace Battle4Beers.Client.Models.Actions.WarriorActions.Swordmaster
{
    using Interfaces;
    public class WindFury : Action, IBuff
    {
        private int duration;
        private int damage;
        public WindFury(string name, int coolDown, int cost, int damage, int duration) : base(name, coolDown, cost)
        {
            this.Damage = damage;
            this.Duration = duration;
        }

        public int Damage
        {
            get { return this.damage; }
            protected set { this.damage = value; }
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
