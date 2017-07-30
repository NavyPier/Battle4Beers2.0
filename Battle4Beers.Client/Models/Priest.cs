using Battle4Beers.Client.Interfaces;

namespace Battle4Beers.Client.Models
{
    public class Priest : Hero, ICaster
    {
        private int mana;

        public Priest(string name, int health) : base(name, health)
        {
        }

        public int Mana
        {
            get { return this.mana; }
            protected set { this.mana = value; }
        }
    }
}
