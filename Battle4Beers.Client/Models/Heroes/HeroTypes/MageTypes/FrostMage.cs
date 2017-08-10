using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Collections.Generic;

namespace Battle4Beers.Client.Models
{
    public class FrostMage : Mage
    {
        private bool icyVeins;
        private bool frostArmored;

        public FrostMage(string name, int health, int healthRegen, List<Action> actions, int armor, int mana, int manaRegen, int spellPower) : base(name, health, healthRegen, actions, armor, mana, manaRegen, spellPower)
        {
            this.IcyVeins = false;
            this.FrostArmored = false;
        }

        public bool FrostArmored
        {
            get { return this.frostArmored; }
            set { this.frostArmored = value; }
        }

        public bool IcyVeins
        {
            get { return icyVeins; }
            protected set { icyVeins = value; }
        }
    }
}
