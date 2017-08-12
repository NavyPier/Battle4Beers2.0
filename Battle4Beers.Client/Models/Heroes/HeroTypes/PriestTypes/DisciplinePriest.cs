using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Battle4Beers.Client.Models
{
    public class DisciplinePriest : Priest, IPassiveActivator
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

        public int PassiveDuration { get; set; }

        public void ActivatePassive(string nameOfPassive, Hero player)
        {
            DisciplinePriest priest = (DisciplinePriest) player;
            priest.IsShielded = true;
            this.PassiveDuration = AbilityDurationConstants.ShieldDuration;
            player.Actions.Where(a => a.Name == nameOfPassive).First().SetCooldown(AbilityCooldownConstants.ShieldCooldown);
        }

        public override void GetDamaged(int amount)
        {
            if(this.IsShielded)
            {
                amount =(int)(amount * 0.6);
            }

            if (this.Armor <= amount)
            {
                amount -= this.Armor;
                this.Health -= amount;
                this.Armor = 0;
            }
            else if (this.Armor > amount)
            {
                this.Armor -= amount;
            }
        }

        public void DeactivatePassive(string nameOfPassive)
        {
            this.IsShielded = false;
        }
    }
}
