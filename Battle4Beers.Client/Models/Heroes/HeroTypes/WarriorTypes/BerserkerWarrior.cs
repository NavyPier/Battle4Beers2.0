using System.Collections.Generic;

namespace Battle4Beers.Client.Models
{
    public class BerserkerWarrior : Warrior
    {
        public BerserkerWarrior(string name, int health, int healthRegen, List<Action> actions, int armor, int rage, int attackPower) : base(name, health, healthRegen, actions, armor, rage, attackPower)
        {
        }
    }
}
