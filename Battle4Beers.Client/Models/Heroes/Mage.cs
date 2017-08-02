using Battle4Beers.Client.Interfaces;
using System.Collections.Generic;
using System;

namespace Battle4Beers.Client.Models
{
    public abstract class Mage : Hero, ICaster, IHero
    {
        private int mana;
        private int spellPower;
        private int manaRegen;

        public Mage(string name, int health, int healthRegen, List<Action> actions, int armor, int mana, int manaRegen, int spellPower) : base(name, health, healthRegen, actions, armor)
        {
            this.Mana = mana;
            this.SpellPower = spellPower;
        }

        public int SpellPower
        {
            get { return this.spellPower; }
            protected set { this.spellPower = value; }
        }

        public int Mana
        {
            get
            {
                return this.mana;
            }
            protected set
            {
                this.mana = value;
            }
        }

        public int ManaRegen
        {
            get
            {
                return this.manaRegen;
            }
            protected set
            {
                this.manaRegen = value;
            }
        }
    }
}
