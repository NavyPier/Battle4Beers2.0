namespace Battle4Beers.Client.Models.Actions.FrostMage
{
    public class FrostArmor : Buff
    {
        private int armor;
        private int percentage;

        public FrostArmor(string name, int coolDown, int cost, int duration, int armor, int percentage) : base(name, coolDown, cost, duration)
        {
            this.Armor = armor;
            this.Percentage = percentage;
        }

        public int Percentage
        {
            get { return this.percentage; }
            protected set { this.percentage = value; }
        }

        public int Armor
        {
            get
            {
                return this.armor;
            }
            protected set
            {
                this.armor = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}: Give {this.Armor} to target. Buff target ally to receive only {this.Percentage}% damage for the next {this.Duration} turns. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
