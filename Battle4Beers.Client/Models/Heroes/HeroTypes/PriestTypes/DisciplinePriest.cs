using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Collections.Generic;

namespace Battle4Beers.Client.Models
{
    public class DisciplinePriest : Priest
    {
        private bool isShielded;

        public DisciplinePriest(string name, int health, int healthRegen, List<Action> actions, int armor, int mana, int manaRegen, int spellPower) : base(name, health, healthRegen, actions, armor, mana, manaRegen, spellPower)
        {
            this.IsShielded = false;
        }

        public bool IsShielded
        {
            get { return this.isShielded; }
            set { this.isShielded = value; }
        } 
    }
}
