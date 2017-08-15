using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System.Collections.Generic;

namespace Battle4Beers.Client.Models
{
    public abstract class Priest : Hero, ICaster
    {
        protected Priest(string name, int health, int healthRegen, List<Action> actions, int armor, int mana, int manaRegen, int spellPower) : base(name, health, healthRegen, actions, armor)
        {
            this.Mana = mana;
            this.SpellPower = spellPower;
        }

        public int SpellPower { get; protected set; }

        public int Mana { get; protected set; }

        public int ManaRegen { get; protected set; }

        public override void ExecuteAction(int cost)
        {
            this.Mana -= cost;
        }

        public override void Regenerate()
        {
            if (this.Health + Constants.PriestHealthRegen < Constants.PriestHealth)
            {
                this.Health += Constants.PriestHealthRegen;
            }
            else
            {
                this.Health = Constants.PriestHealth;
            }

            if(this.Mana + Constants.PriestManaRegen < Constants.PriestMana)
            {
                this.Mana += Constants.PriestManaRegen;
            }
            else
            {
                this.Mana = Constants.PriestMana;
            }
        }
    }
}
