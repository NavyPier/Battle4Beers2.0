using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System;

namespace Battle4Beers.Client.Models.Actions.PriestActions.HolyPriest
{
    public class HolyNova : Action, IAgressiveAction
    {
        private int damage;

        public HolyNova(string name, int coolDown, int cost, int damage) : base(name, coolDown, cost)
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
        }

        public override string ToString()
        {
            return $"{this.Name}: Damage all of your opponents by {this.damage}. Cooldown: {this.CoolDown}, Cost: {this.Cost} Mana";
        }
    }
}
