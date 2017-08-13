using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System.Collections.Generic;

namespace Battle4Beers.Client.Models
{
    public abstract class Mage : Hero, ICaster
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

        public override void ExecuteAction(int cost)
        {
            this.Mana -= cost;
        }

        public override void Regenerate()
        {
            if (this.Health + Constants.MageHealthRegen < Constants.MageHealth)
            {
                this.Health += Constants.MageHealthRegen;
            }
            else
            {
                this.Health = Constants.MageHealth;
            }

            if (this.Mana + Constants.MageManaRegen < Constants.MageMana)
            {
                this.Mana += Constants.MageManaRegen;
            }
            else
            {
                this.Mana = Constants.MageMana;
            }
        }
    }
}
