using System;
using Battle4Beers.Client.Interfaces;

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
            BerserkerWarrior playerOnTurn = (BerserkerWarrior)player;
            if(playerOnTurn.IsBerserk)
            {
                enemy.GetDamaged(this.Damage * 2);
            }
            else
            {
                enemy.GetDamaged(this.Damage);
            }
        }

        public override string ToString()
        {
            return $"{this.Name}: Damage the selected opponent for {this.Damage} damage. Cooldown: {this.CoolDown}, Cost: {this.Cost} Rage";
        }
    }
}
