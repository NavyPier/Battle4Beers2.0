using System;
using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System.Linq;
using Battle4Beers.Client.BattleGround;

namespace Battle4Beers.Client.Models.Actions.WarriorActions.Berseker
{
    public class WildAxes : Action, IAgressiveAction
    {
        private int damage;

        public WildAxes(string name, int coolDown, int cost, int damage) : base(name, coolDown, cost)
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
            var isCrit = CriticalChecker.CheckForCrit(player);
            BerserkerWarrior playerOnTurn = (BerserkerWarrior)player;
            player.Actions.Where(a => a.Name == this.Name).First().SetCooldown(AbilityCooldownConstants.WildAxesCooldown);
            if (playerOnTurn.IsBerserk)
            {
                if(isCrit)
                {
                    enemy.GetDamaged(this.Damage * 4);
                    CriticalPrinter.PrintCritical(player);
                }
                else
                {
                    enemy.GetDamaged(this.Damage * 2);
                }

                playerOnTurn.PassiveDuration--;
                if(playerOnTurn.PassiveDuration <= 0)
                {
                    playerOnTurn.IsBerserk = false;
                }
            }
            else
            {
                if (isCrit)
                {
                    enemy.GetDamaged(this.Damage * 2);
                    CriticalPrinter.PrintCritical(player);
                }
                else
                {
                    enemy.GetDamaged(this.Damage);
                }
            }
        }

        public override string ToString()
        {
            return $"{this.Name}: Damage the selected opponent for {this.Damage} damage. Cooldown: {this.CoolDown}, Cost: {this.Cost} Rage";
        }
    }
}
