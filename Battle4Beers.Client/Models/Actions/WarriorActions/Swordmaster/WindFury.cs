namespace Battle4Beers.Client.Models.Actions.WarriorActions.Swordmaster
{
    using Interfaces;
    using Utilities.Constants;

    public class WindFury : Action
    {
        private int damage;

        public WindFury(string name, int coolDown, int cost, int damage) : base(name, coolDown, cost)
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
            return $"{this.Name}: Damage the selected opponent for {this.Damage} damage. Cooldown: {this.CoolDown}, Cost: {this.Cost} Rage";
        }

    }
}
