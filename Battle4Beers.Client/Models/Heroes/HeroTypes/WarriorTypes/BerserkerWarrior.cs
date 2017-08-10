using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Collections.Generic;

namespace Battle4Beers.Client.Models
{
    public class BerserkerWarrior : Warrior
    {
        private bool isBerserk;

        public BerserkerWarrior(string name, int health, int healthRegen, List<Action> actions, int armor, int rage, int attackPower) : base(name, health, healthRegen, actions, armor, rage, attackPower)
        {
            this.IsBerserk = false;
        }

        public bool IsBerserk
        {
            get { return this.isBerserk; }
            set { this.isBerserk = value; }
        }
    }
}
