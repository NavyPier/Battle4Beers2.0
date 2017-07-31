namespace Battle4Beers.Client.Models.Actions.WarriorActions.Berseker
{
    public class WildAxes : Action
    {
        private int damage;
        public WildAxes(string name, int coolDown, int cost, int damage) : base(name, coolDown, cost)
        {
            this.Damage = damage;
        }

        public int Damage
        {
            get { return this.damage; }
            protected set { this.damage = value; }
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}
