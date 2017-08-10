using System;
using System.Collections.Generic;

namespace Battle4Beers.Client.Models
{
    public class SwordmasterWarrior : Warrior
    {
        private bool criticalStrike;

        public SwordmasterWarrior(string name, int health, int healthRegen, List<Action> actions, int armor, int rage, int attackPower) : base(name, health, healthRegen, actions, armor, rage, attackPower)
        {
            this.CriticalStrike = false;
        }

        public bool CriticalStrike
        {
            get { return this.criticalStrike; }
            set { this.criticalStrike = value; }
        }
    }
}
