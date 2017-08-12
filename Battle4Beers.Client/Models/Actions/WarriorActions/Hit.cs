using Battle4Beers.Client.Interfaces;
using Battle4Beers.Client.Utilities.Constants;
using System;

namespace Battle4Beers.Client.Models.Actions.WarriorActions
{
    public class Hit : Action, IAgressiveAction
    {
        private int damage;
        private int rageOnHit;

        public Hit(string name, int coolDown, int cost, int damage) : base(name, coolDown, cost)
        {
            this.RageOnHit = Constants.WarriorRageOnHit;
            this.Damage = damage;
            this.Type = "agressive";
        }

        public int RageOnHit
        {
            get { return this.rageOnHit; }
            protected set { this.rageOnHit = value; }
        }

        public int Damage
        {
            get { return this.damage; }
            protected set { this.damage = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: Damage the selected opponent for {this.Damage} damage.";
        }

        public void ExecuteAgressiveAction(Hero player, Hero enemy)
        {
            enemy.GetDamaged(this.Damage);
            Warrior playerOnTurn = (Warrior)player;
            playerOnTurn.GetRageOnHit();
        }
    }
}
