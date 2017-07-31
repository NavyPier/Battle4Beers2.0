namespace Battle4Beers.Client.Models
{
    public class FrostMage : Mage
    {
        private int frostArmor;

        public FrostMage(string name, int health, int mana, int spellPower) : base(name, health, mana, spellPower)
        {
        }

        public int FrostArmor
        {
            get { return this.frostArmor; }
            protected set { this.frostArmor = value; }
        }
    }
}
