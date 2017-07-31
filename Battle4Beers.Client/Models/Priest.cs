using Battle4Beers.Client.Interfaces;

namespace Battle4Beers.Client.Models
{
    public abstract class Priest : Hero, ICaster, IHero
    {
        private int mana;
        private int spellPower;

        public Priest(string name, int health, int mana, int spellPower) : base(name, health)
        {
            this.Mana = mana;
            this.SpellPower = spellPower;
        }

        public int SpellPower
        {
            get { return this.spellPower; }
            protected set { this.spellPower = value; }
        }

        public int Mana
        {
            get { return this.mana; }
            protected set { this.mana = value; }
        }
    }
}
