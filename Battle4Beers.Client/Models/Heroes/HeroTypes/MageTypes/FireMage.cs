using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Collections.Generic;

namespace Battle4Beers.Client.Models
{
    public class FireMage : Mage
    {
        private bool fireArmored;

        public FireMage(string name, int health, int healthRegen, List<Action> actions, int armor, int mana, int manaRegen, int spellPower) : base(name, health, healthRegen, actions, armor, mana, manaRegen, spellPower)
        {
            this.FireArmored = false;
        }

        public bool FireArmored
        {
            get { return fireArmored; }
            set { fireArmored = value; }
        }
    }
}
