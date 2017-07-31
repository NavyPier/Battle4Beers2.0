using System;

namespace Battle4Beers.Client.Models.Actions.FireMage
{
    public class PyroBlast : Action
    {
        private int damage;

        public PyroBlast(string name, int coolDown, int cost, int damage) : base(name, coolDown, cost)
        {
            this.Damage = damage;
        }

        public int Damage
        {
            get { return this.damage; }
            protected set { this.damage = value; }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
