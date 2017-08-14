using System;
using Battle4Beers.Client.Interfaces;
using System.Linq;
using Battle4Beers.Client.Utilities.Constants;

namespace Battle4Beers.Client.Models.Actions
{
    public class FireArmor : Action, IFriendlyAction
    {
        private int heal;
        private int armor;

        public FireArmor(string name, int coolDown, int cost, int heal, int armor) : base(name, coolDown, cost)
        {
            this.Heal = heal;
            this.Armor = armor;
            this.Type = "friendly";
        }

        public int Heal
        {
            get { return this.heal; }
            protected set { this.heal = value; }
        }

        public int Armor
        {
            get { return this.armor; }
            protected set { this.armor = value; }
        }

        public void DoFriendlyAction(Hero player, Hero ally)
        {
            ally.GetHealed(this.Heal);
            ally.GainArmor(this.Armor);
            player.Actions.First(a => a.Name == this.Name).SetCooldown(AbilityCooldownConstants.FireArmorCooldown);
        }

        public override string ToString()
        {
            return $"{this.Name}: Give {this.Armor} armor to target. Heal target for {this.Heal}. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }

        
    }
}
