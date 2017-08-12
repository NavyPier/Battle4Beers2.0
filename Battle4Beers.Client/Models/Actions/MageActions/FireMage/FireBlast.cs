using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Linq;

namespace Battle4Beers.Client.Models.Actions
{
    public class FireBlast : Action, IAgressiveAction
    {
        private int damage;

        public FireBlast(string name, int coolDown, int cost, int damage) : base(name, coolDown, cost)
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
            enemy.GetDamaged(this.Damage);
            player.Actions.Where(a => a.Name == this.Name).First().SetCooldown(AbilityCooldownConstants.FireBlastCooldown);

            FireMage fireMage = (FireMage)player;
            fireMage.PassiveDuration--;
            if (fireMage.PassiveDuration <= 0)
            {
                fireMage.FireArmored = false;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}: Damage the selected opponent for {this.Damage} damage. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
