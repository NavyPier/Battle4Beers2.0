namespace Battle4Beers.Client.Models
{
    public class ProtectionWarrior : Warrior
    {
        private int armor;

        public ProtectionWarrior(string name, int health, int rage, int attackPower, int armor) : base(name, health, rage, attackPower)
        {
            this.Armor = armor;
        }

        public int Armor
        {
            get { return armor; }
            protected set { armor = value; }
        }
    }
}
