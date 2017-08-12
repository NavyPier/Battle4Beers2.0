using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System.Linq;
using System;

namespace Battle4Beers.Client.Models.Actions
{
    public class FrostBolt : Action, IAgressiveAction
    {
        private int damage;

        public FrostBolt(string name, int coolDown, int cost, int damage) : base(name, coolDown, cost)
        {
            this.Damage = damage;
            this.Type = "agressive";
        }

        public int Damage
        {
            get { return this.damage; }
            protected set { this.damage = value; }
        }

        public void ExecuteAgressiveAction(Hero player, Hero enemy)
        {
            FrostMage mage = (FrostMage)player;
            if(mage.IcyVeins)
            {
                enemy.GetDamaged((int)(this.Damage * 1.5));
                mage.IcyVeinsDuration--;
            }
            else
            {
                enemy.GetDamaged(this.Damage);
            }

            if (mage.IcyVeinsDuration <= 0)
            {
                mage.IcyVeins = false;
            }

            player.Actions.Where(a => a.Name == this.Name).First().SetCooldown(AbilityCooldownConstants.FrostBoltCooldown);
        }

        public override string ToString()
        {
            return $"{this.Name}: Damage the selected opponent for {this.Damage} damage. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
