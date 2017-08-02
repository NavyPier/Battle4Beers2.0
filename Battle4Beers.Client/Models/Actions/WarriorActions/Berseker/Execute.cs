namespace Battle4Beers.Client.Models.Actions.WarriorActions.Berseker
{
    public class Execute : Action
    {
        private int damage;

        public Execute(string name, int coolDown, int cost, int damage) : base(name, coolDown, cost)
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
            return $"{this.Name}: Execute the target if his HP is below {this.damage}";
        }
    }
}
