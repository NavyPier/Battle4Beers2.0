namespace Battle4Beers.Client.Models.Actions.FireMage
{
    public class FireArmor : Buff
    {
        private int damageOverTime;
        private int armor;

        public FireArmor(string name, int coolDown, int cost, int duration, int damageOverTime, int armor) : base(name, coolDown, cost, duration)
        {
            this.DamageOverTime = damageOverTime;
            this.Armor = armor;
        }

        public int DamageOverTime
        {
            get { return this.damageOverTime; }
            protected set { this.damageOverTime = value; }
        }

        public int Armor
        {
            get { return this.armor; }
            protected set { this.armor = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: Give {this.Armor} to target. If anyone attacks the person with Fire Armor on, they get burned for {this.DamageOverTime} damage. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
