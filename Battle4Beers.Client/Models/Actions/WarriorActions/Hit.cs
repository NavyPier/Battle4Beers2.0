using Battle4Beers.Client.Utilities.Constants;
using System;

namespace Battle4Beers.Client.Models.Actions.WarriorActions
{
    public class Hit : Action
    {
        private int rageGeneration;
        private int damage;
        public Hit(string name, int coolDown, int cost, int damage) : base(name, coolDown, cost)
        {
            this.RageGeneration = 20;
            this.Damage = damage;
        }

        public int Damage
        {
            get { return this.damage; }
            protected set { this.damage = value; }
        }

        public int RageGeneration
        {
            get { return this.rageGeneration; }
            protected set { this.rageGeneration = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}: Damage the selected opponent for {this.Damage} damage. Generate {this.rageGeneration} rage.";
        }
    }
}
