namespace Battle4Beers.Client.Models
{
    public class FrostMage : Mage
    {
        private int frostArmor;

        public FrostMage(string name, int health, int mana, int spellPower) : base(name, health)
        {
            this.Mana = mana;
            this.SpellPower = spellPower;
        }

        public int FrostArmor
        {
            get { return this.frostArmor; }
            protected set { this.frostArmor = value; }
        }
    }
}
