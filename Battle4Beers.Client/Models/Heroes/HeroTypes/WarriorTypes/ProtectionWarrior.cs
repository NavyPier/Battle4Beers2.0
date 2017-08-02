using System.Collections.Generic;

namespace Battle4Beers.Client.Models
{
    public class ProtectionWarrior : Warrior
    {
        public ProtectionWarrior(string name, int health, int healthRegen, List<Action> actions, int armor, int rage, int attackPower) : base(name, health, healthRegen, actions, armor, rage, attackPower)
        {
        }
    }
}
