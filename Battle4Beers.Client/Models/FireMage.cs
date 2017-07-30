namespace Battle4Beers.Client.Models
{
    public class FireMage : Mage
    {
        private int fireArmor;

        public FireMage(string name, int health, int mana, int spellPower) : base(name, health)
        {
            this.Mana = mana;
            this.SpellPower = spellPower;
        }

        public int FireArmor
        {
            get { return this.fireArmor; }
            protected set { this.fireArmor = value; }
        }
    }
}
