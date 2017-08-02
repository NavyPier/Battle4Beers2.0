namespace Battle4Beers.Client.Models.Actions.WarriorActions
{
    using Interfaces;
    using Utilities.Constants;

    public class ShieldSlam : Action, IBuff
    {
        private int duration;
        private int damage;

        public ShieldSlam(string name, int coolDown, int cost, int damage, int duration) : base(name, coolDown, cost)
        {
            this.Duration = duration;
            this.Damage = damage;
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
            return $"{this.Name}: Damage the selected opponent for {this.Damage} damage. Stun target for {this.Duration} turns. Cooldown: {this.CoolDown}, Cost: {this.Cost} Rage";
        }

    }
}
