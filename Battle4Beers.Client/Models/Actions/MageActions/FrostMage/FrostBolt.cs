using System;
using Battle4Beers.Client.Interfaces;

namespace Battle4Beers.Client.Models.Actions.FrostMage
{
    public class FrostBolt : Action, IBuff
    {
        private int damage;
        private int duration;

        public FrostBolt(string name, int coolDown, int cost, int damage, int duration) : base(name, coolDown, cost)
        {
            this.Damage = damage;
        }

        public int Damage
        {
            get { return this.damage; }
            protected set { this.damage = value; }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            protected set { this.duration = value; }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
