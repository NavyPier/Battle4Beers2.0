using System;
using System.Collections.Generic;

namespace Battle4Beers.Client.Models
{
    public class ProtectionWarrior : Warrior
    {
        private bool hibernating;

        public ProtectionWarrior(string name, int health, int healthRegen, List<Action> actions, int armor, int rage, int attackPower) : base(name, health, healthRegen, actions, armor, rage, attackPower)
        {
            this.Hibernating = false;
        }

        public bool Hibernating
        {
            get { return this.hibernating; }
            set { this.hibernating = value; }
        }
    }
}
