using Battle4Beers.Client.Interfaces;
using System.Collections.Generic;

namespace Battle4Beers.Client.Models
{
    public class SwordmasterWarrior : Warrior, IPassiveActivator
    {
        public SwordmasterWarrior(string name, int health, int healthRegen, List<Action> actions, int armor, int rage, int attackPower) : base(name, health, healthRegen, actions, armor, rage, attackPower)
        {
            this.CriticalStrike = false;
        }

        public bool CriticalStrike { get; set; }

        public int PassiveDuration { get; set; }

        public void ActivatePassive(string nameOfPassive, Hero player)
        {
            this.CriticalStrike = true;
        }

        public void DeactivatePassive(string nameOfPassive)
        {
        }
    }
}
