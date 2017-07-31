using System.Collections.Generic;

namespace Battle4Beers.Client.Models
{
    public class ProtectionWarrior : Warrior
    {
        private int armor;

        public ProtectionWarrior(string name, int health, int healthRegen, List<Action> actions, int armor, int rage, int attackPower) : base(name, health, healthRegen, actions, armor, rage, attackPower)
        {
        }

        public int Armor
        {
            get { return armor; }
            protected set { armor = value; }
        }
    }
}
