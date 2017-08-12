using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System;
using System.Linq;

namespace Battle4Beers.Client.Models.Actions.WarriorActions.Swordmaster
{
    public class MirrorImage : Action, IAgressiveAction
    {
        private int damage;

        public MirrorImage(string name, int coolDown, int cost, int damage) : base(name, coolDown, cost)
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
            enemy.StunnedDuration++;
            SwordmasterWarrior playerOnTurn = (SwordmasterWarrior)player;
            player.Actions.Where(a => a.Name == this.Name).First().SetCooldown(AbilityCooldownConstants.MirrorImageCooldown);
            if(playerOnTurn.CriticalStrike)
            {
                var random = new Random().Next(1, 101);
                if(random <= 35)
                {
                    enemy.GetDamaged(this.Damage);
                }
            }
            else
            {
                enemy.GetDamaged(this.Damage);
            }
        }

        public override string ToString()
        {
            return $"{this.Name}: Damage the selected opponent for {this.Damage} damage. Stun target for {AbilityDurationConstants.MirrorImageDuration} turns. Cooldown: {this.CoolDown}, Cost: {this.Cost} Rage";
        }

    }
}
