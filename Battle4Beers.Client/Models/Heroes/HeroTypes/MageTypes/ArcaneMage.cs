using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Collections.Generic;

namespace Battle4Beers.Client.Models
{
    public class ArcaneMage : Mage
    {
        private bool isAmplified;

        public ArcaneMage(string name, int health, int healthRegen, List<Action> actions, int armor, int mana, int manaRegen, int spellPower) : base(name, health, healthRegen, actions, armor, mana, manaRegen, spellPower)
        {
            this.IsAmplified = false;
        }

        public bool IsAmplified
        {
            get { return this.isAmplified; }
            set { this.isAmplified = value; }
        }
    }
}
