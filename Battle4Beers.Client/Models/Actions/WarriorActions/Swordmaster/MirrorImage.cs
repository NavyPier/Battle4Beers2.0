namespace Battle4Beers.Client.Models.Actions.WarriorActions.Swordmaster
{
    public class MirrorImage : Debuff
    {
        private int damage;
        public MirrorImage(string name, int coolDown, int cost, int duration, int damage) : base(name, coolDown, cost, duration)
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
            return $"{this.Name}: Damage the selected opponent for {this.Damage} damage. Stun target for {this.Duration} turns. Cooldown: {this.CoolDown}, Cost: {this.Cost} Rage";
        }

    }
}
