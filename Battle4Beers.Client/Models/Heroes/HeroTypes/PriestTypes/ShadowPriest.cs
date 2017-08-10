using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Collections.Generic;

namespace Battle4Beers.Client.Models
{
    public class ShadowPriest : Priest
    {
        private bool sadist;

        public ShadowPriest(string name, int health, int healthRegen, List<Action> actions, int armor, int mana, int manaRegen, int spellPower) : base(name, health, healthRegen, actions, armor, mana, manaRegen, spellPower)
        {
            this.Sadist = false;
        }

        public bool Sadist
        {
            get { return this.sadist; }
            set { this.sadist = value; }
        }
    }
}
