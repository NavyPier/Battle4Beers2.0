using System;

namespace Battle4Beers.Client.Models.Actions.FireMage
{
    public class Incinerate : Action
    {
        private int damage;

        public Incinerate(string name, int coolDown, int cost, int damage) : base(name, coolDown, cost)
        {
            this.Damage = damage;
        }

        public int Damage;

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
