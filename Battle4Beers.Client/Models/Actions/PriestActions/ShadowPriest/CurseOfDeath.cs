namespace Battle4Beers.Client.Models.Actions.PriestActions.ShadowPriest
{
    public class CurseOfDeath : Debuff
    {
        private int damageOverTime;

        public CurseOfDeath(string name, int coolDown, int cost, int duration, int damageOverTime) : base(name, coolDown, cost, duration)
        {
            this.DamageOverTime = damageOverTime;
        }

        public int DamageOverTime
        {
            get { return this.damageOverTime; }
            protected set { this.damageOverTime = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: Damage the selected opponent for {this.DamageOverTime} damage for the next {this.Duration} turns. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
